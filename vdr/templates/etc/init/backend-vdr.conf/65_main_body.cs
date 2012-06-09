  # loading main config
  . /usr/lib/vdr/config-loader.sh

  # loading plugin config
  . /usr/lib/vdr/plugin-loader.sh

  # loading recoring commands
  . /usr/lib/vdr/commands-loader.sh
  mergecommands "reccmds"

  # set environment
  LANG=$VDR_LANG
  LC_ALL=$VDR_LANG
  export LANG LC_ALL

  # set charset override
  if [ -n "$VDR_CHARSET_OVERRIDE" ] ; then
    export VDR_CHARSET_OVERRIDE=$VDR_CHARSET_OVERRIDE
  fi

  # loading recoring commands
  . /usr/lib/vdr/commands-loader.sh
  mergecommands "reccmds"

  # set environment
  LANG=$VDR_LANG
  LC_ALL=$VDR_LANG
  export LANG LC_ALL

  # set charset override
  if [ -n "$VDR_CHARSET_OVERRIDE" ] ; then
    export VDR_CHARSET_OVERRIDE=$VDR_CHARSET_OVERRIDE
  fi

  # set shutdown command
  test "$ENABLE_SHUTDOWN" = "1" && VDRSHUTDOWN="/usr/lib/vdr/vdr-shutdown.wrapper" \
                                || VDRSHUTDOWN="/usr/lib/vdr/vdr-shutdown-message"

  # start vdr
  exec $DAEMON --lirc=$LIRC -v $VIDEO_DIR -c $CFG_DIR -L $PLUGIN_DIR -r $REC_CMD -s $VDRSHUTDOWN \
    -E $EPG_FILE -u $USER -g /tmp --port $SVDRP_PORT $OPTIONS "${PLUGINS[@]}" $REDIRECT &> /var/log/vdr/startup.log


