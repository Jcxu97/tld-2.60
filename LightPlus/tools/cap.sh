#!/usr/bin/env bash
# cap.sh MODE NAME [r] : turn the pass on in debug MODE, grab one frame from the plugin, then restore the config.
# With r the relight pass is captured and MODE goes to RelightDebug.
M="D:/Steam/steamapps/common/TheLongDark/Mods"
J="$M/LightPlus.json"
D="${LPDIR:-D:/Steam/steamapps/common/TheLongDark/UserData/LightPlus}"
OUT="D:/Github/browser-harness/workspace/screenshots"
cp "$J" "$J.capbak"
if [ "$3" = r ]; then C=capture1; sed -i "s/\"RelightDebug\": [0-9]*/\"RelightDebug\": $1/" "$J"
else C=capture; sed -i "s/\"Shafts\": [a-z]*/\"Shafts\": true/; s/\"ShaftDebug\": [0-9]*/\"ShaftDebug\": $1/" "$J"; fi
sleep 1.6
rm -f "$D/$C.bmp" "$D/${C}_in.bmp"
touch "$D/$C.req"
for i in $(seq 1 40); do [ -f "$D/$C.req" ] || break; sleep 0.1; done
cp "$J.capbak" "$J"; rm -f "$J.capbak"
[ -f "$D/$C.req" ] && { rm -f "$D/$C.req"; echo "no capture (pass not running?)"; exit 1; }
python -I -c "from PIL import Image; import sys; [Image.open(a).transpose(Image.FLIP_TOP_BOTTOM).save(b, quality=88) for a, b in ((sys.argv[1], sys.argv[2]), (sys.argv[3], sys.argv[4]))]" "$D/$C.bmp" "$OUT/$2.jpg" "$D/${C}_in.bmp" "$OUT/$2_in.jpg"
echo "$OUT/$2.jpg"
