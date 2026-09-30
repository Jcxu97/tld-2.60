# 生成 TldHacks/src/PinyinData.cs —— 物品生成器搜索框用的汉字拼音表。
# 依赖:pip install pypinyin
# 表结构:0x4E00..0x9FFF 每个码位一个 char,值 = 0x100 + 音节序号 + 1,0x100 表示这个字没有读音。
#   查表是 O(1) 下标,没有字典、运行期零分配。多音字只取最常用的一个读音(搜索够用)。
import os
from pypinyin import lazy_pinyin, Style

START, END = 0x4E00, 0x9FFF
OFFSET = 0x100

syllables = []
index_of = {}
table = []
for cp in range(START, END + 1):
    ch = chr(cp)
    got = lazy_pinyin(ch, style=Style.NORMAL)
    syl = got[0] if got else ""
    if not syl.isascii() or not syl.isalpha():
        table.append(OFFSET)
        continue
    i = index_of.get(syl)
    if i is None:
        i = len(syllables)
        index_of[syl] = i
        syllables.append(syl)
    table.append(OFFSET + i + 1)

assert max(table) < 0xD800, "音节数超出单 char 编码范围"

out = os.path.join(os.path.dirname(__file__), "..", "TldHacks", "src", "PinyinData.cs")
with open(out, "w", encoding="utf-8", newline="\r\n") as f:
    f.write("// 本文件由 tools/gen_pinyin_table.py 生成,不要手改。\n")
    f.write("// 汉字 → 拼音音节查表,给物品生成器的搜索框用(见 PinyinSearch.cs)。\n")
    f.write("namespace TldHacks;\n\n")
    f.write("internal static class PinyinData\n{\n")
    f.write("    internal const int First = 0x%04X;\n" % START)
    f.write("    internal const int Last  = 0x%04X;\n" % END)
    f.write("    internal const int Base  = 0x%04X;\n\n" % OFFSET)
    f.write("    // 逗号分隔,首次搜索时 split 一次(%d 个音节)\n" % len(syllables))
    f.write('    internal static readonly string Syllables = "%s";\n\n' % ",".join(syllables))
    f.write("    // 每个码位一个 char:Base 表示无读音,否则 char - Base - 1 是音节下标。\n")
    f.write("    // 两个省体积的写法,别改:整条字面量(拆成多段用 + 拼,每段自己还要再进一遍字符串堆);\n")
    f.write("    // static readonly 而不是 const(const 的值会在元数据里多存一份)。\n")
    f.write('    internal static readonly string Index = "')
    f.write("".join("\\u%04X" % v for v in table))
    f.write('";\n}\n')

print("syllables:", len(syllables), "codepoints:", len(table), "->", os.path.normpath(out))
