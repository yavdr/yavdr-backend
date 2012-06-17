description "yavdr dummy backend"
author "yaVDR Release-Team <release@yavdr.org>"

env HOME=/yavdr
export HOME

setuid yavdr
setgid yavdr

nice -10

kill timeout 60
normal exit 0
expect stop

respawn
respawn limit 10 5

