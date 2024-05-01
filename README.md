# Mouse-Jiggler

Mouse Jiggler is a very simple piece of software whose sole function is to "fake" mouse input to Windows, and jiggle the mouse pointer back and forth.

Useful for avoiding screensavers or other things triggered by idle detection that, for whatever reason, you can't turn off any other way; or as a quick way to stop a screensaver activating during an installation or when monitoring a long operation without actually having to muck about with the screensaver settings.


Usage:
  MouseJiggler [options]

Options:
  -j, --jiggle               Start with jiggling enabled.
  -m, --minimized            Start minimized (sets persistent option). [default: False]
  -z, --zen                  Start with zen (invisible) jiggling enabled (sets persistent option). [default: False]
  -s, --seconds <seconds>    Set number of seconds for the jiggle interval (sets persistent option). [default: 1]
  --version                  Show version information
  -?, -h, --help             Show help and usage information
```

The `-j` command-line switch tells Mouse Jiggler to commence jiggling immediately on startup.





