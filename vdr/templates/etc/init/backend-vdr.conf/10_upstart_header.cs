description "yavdr dummy backend"
author "yaVDR Release-Team <release@yavdr.org>"

env HOME=/var/lib/vdr
export HOME

nice -10

kill timeout 60
normal exit 0
expect stop

respawn
respawn limit 10 5

umask 0000

