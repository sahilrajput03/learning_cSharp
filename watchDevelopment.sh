#!/bin/bash
nodemon -q -e cs -x "mcs $@ -out:binary && mono binary"
# ABOVE IS EQUIVALENT TO BELOW (say $@ is 1.cs):
# mcs 1.cs -out:binary && mono binary
