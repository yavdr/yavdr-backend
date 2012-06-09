  # disable remote - handle by frontend
  /usr/bin/vdr-dbus-send /Remote remote.Disable ||:

  # start frontend if possible
  /sbin/initctl emit start-frontend ||:
