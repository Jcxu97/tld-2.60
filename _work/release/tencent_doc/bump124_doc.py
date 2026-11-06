p = r'D:\Github\tld--2.55\_work\release\tencent_doc\doc.txt'
raw = open(p, 'rb').read()
bom = raw.startswith(b'\xef\xbb\xbf')
s = raw.decode('utf-8-sig')

pairs = [
    ('当前网盘上是 TldHacks V12.3，适配游戏 2.60 版（11 月 6 日的热补丁）。2.60 删了游戏里的一个方法，TraderMoving、SCPlusFix++、Architect 三个 mod 用到了它，当天已修好，V12.3 版本号不变重新打包上传，11 月 6 日中午以前下过的要重新下一次。',
     '当前网盘上是 TldHacks V12.4，适配游戏 2.60 版（11 月 6 日的热补丁）。'),
    ('铣床、弹药工作台和炉子要装 SCPlusFix++ |',
     '铣床、弹药工作台和炉子要装 SCPlusFix++。鼠标停在某一行的生成按钮上，屏幕另一半会弹出这件物品的大图和游戏原生的描述，不想看就关掉搜索框左边的显示图片开关 |'),
]
for a, b in pairs:
    assert s.count(a) == 1, (a, s.count(a))
    s = s.replace(a, b)
n = s.count('TldHacks-v12.3')
s = s.replace('TldHacks-v12.3', 'TldHacks-v12.4')
open(p, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + s.encode('utf-8'))
print('ok, v12.3 names replaced:', n)
