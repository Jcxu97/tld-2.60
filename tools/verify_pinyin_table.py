# 自查 PinyinData.cs:按 C# 端相同的查表逻辑算几个物品名的全拼和首字母。
import os
import re

src = open(os.path.join(os.path.dirname(__file__), "..", "TldHacks", "src", "PinyinData.cs"),
           encoding="utf-8").read()
syl = re.search('Syllables = "([^"]+)"', src).group(1).split(",")
idx = [int(x, 16) for x in re.findall(r"\\u([0-9A-F]{4})", src)]
print("syllables:", len(syl), "index:", len(idx))


def py(ch):
    cp = ord(ch)
    if not (0x4E00 <= cp <= 0x9FFF):
        return None
    v = idx[cp - 0x4E00] - 0x100
    return None if v <= 0 else syl[v - 1]


for w in ["橡实", "牛蒡根", "沙丁鱼罐头", "胡须地衣", "炼乳", "焗豆", "鲑鱼",
          "虹鳟鱼", "熊肉", "军用速食口粮", "枫糖糖浆", "格兰诺拉燕麦卷"]:
    print(w, "|", "".join(py(c) or "?" for c in w), "|", "".join((py(c) or "?")[0] for c in w))
