# -*- coding: utf-8 -*-
"""
verify_en.py — 校验 src/ModSettingsEnData.cs 与 Settings.cs 的一致性。
硬性检查(任一失败 exit 1):
  1. 每个数组元素个数为偶数(扁平 kv 对)
  2. key 全部是 Settings.cs 里真实存在的字段名(否则运行时静默失效)
  3. 无重复 key
  4. value 非空、不含中文
  5. Choice 的 '|' 段数与原 [Choice] 数组长度严格一致 —— 长度变了 ValidateFor 会在
     TldHacksSettings 构造期抛异常 → 存档进不去
  6. Section/Name/Description/Choice 的 key 上确实带对应 attribute
"""
import os
import re
import sys

import harvest_en as H

SRC = H.SRC
DATA = os.path.join(SRC, "ModSettingsEnData.cs")
LIT = re.compile(r'"((?:[^"\\]|\\.)*)"')


def read_array(text, name):
    seg = text.split("string[] " + name)[1].split("};")[0]
    out = []
    for ln in seg.split("\n"):
        ln = re.sub(r"//.*$", "", ln)
        out += [H.cs_unescape(m) for m in LIT.findall(ln)]
    return out


def main():
    fields = dict(H.parse_settings())
    with open(DATA, encoding="utf-8-sig", newline="") as fh:
        text = fh.read().replace("\r\n", "\n")

    errors = []
    for name, attr in (("Names", "Name"), ("Descriptions", "Description"),
                       ("Sections", "Section"), ("Choices", "Choice")):
        arr = read_array(text, name)
        if len(arr) % 2:
            errors.append("%s: 元素个数 %d 不是偶数" % (name, len(arr)))
            continue
        keys, vals = arr[0::2], arr[1::2]
        for k in keys:
            if k not in fields:
                errors.append("%s: key '%s' 不是 Settings.cs 的字段" % (name, k))
            elif attr not in fields[k]:
                errors.append("%s: 字段 '%s' 没有 [%s] attribute" % (name, k, attr))
        dup = [k for k in set(keys) if keys.count(k) > 1]
        if dup:
            errors.append("%s: 重复 key %s" % (name, dup))
        for k, v in zip(keys, vals):
            if not v.strip():
                errors.append("%s: '%s' 的英文为空" % (name, k))
            if H.has_cjk(v) and name != "Choices":
                errors.append("%s: '%s' 的英文仍含中文: %s" % (name, k, v))
            if name == "Choices" and k in fields and "Choice" in fields[k]:
                want, got = len(fields[k]["Choice"]), len(v.split("|"))
                if want != got:
                    errors.append("Choices: '%s' 段数 %d != 原数组长度 %d(会让构造期抛异常)"
                                  % (k, got, want))
        print("%-13s %3d 条" % (name, len(keys)))

    if errors:
        print("\nFAIL:")
        for e in errors:
            print("  " + e)
        sys.exit(1)
    print("\nOK — 全部校验通过")


if __name__ == "__main__":
    main()
