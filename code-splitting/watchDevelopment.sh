#!/bin/bash
echo $@
nodemon -q -e cs -x "mcs $* -out:binary && mono binary"
# ABOVE IS EQUIVALENT TO BELOW (say $@ is 1.cs):
# mcs 1.cs -out:binary && mono binary
# This is different from root watchDevelopment file as it has $* instead of $@.
# diff b/w $* and $@: https://stackoverflow.com/a/22589064/10012446