#!/usr/bin/env bash
# ab.sh NAME "sed1" "sed2" ... : capture the final frame once per config variant, then restore the config
# and paste all variants side by side into NAME.jpg. Each argument is "MODE|sed script", applied to a fresh copy.
J="D:/Steam/steamapps/common/TheLongDark/Mods/LightPlus.json"
OUT="D:/Github/browser-harness/workspace/screenshots"
T="$(dirname "$0")"
NAME=$1; shift
cp "$J" "$J.ab"
i=0; list=()
for s in "$@"; do
  m=${s%%|*}; s=${s#*|}
  cp "$J.ab" "$J"; sed -i "$s" "$J"; sleep 1.5
  bash "$T/cap.sh" "$m" "${NAME}_$i" >/dev/null || echo "variant $i failed"
  list+=("$OUT/${NAME}_$i.jpg"); i=$((i+1))
done
cp "$J.ab" "$J"; rm -f "$J.ab"
python -I -c "
import sys
from PIL import Image
ims=[Image.open(p) for p in sys.argv[2:]]
w,h=ims[0].size
c=Image.new('RGB',(w*len(ims),h))
for k,im in enumerate(ims): c.paste(im,(w*k,0))
c.save(sys.argv[1], quality=88)
" "$OUT/$NAME.jpg" "${list[@]}"
echo "$OUT/$NAME.jpg"
