@echo off
set repro=PlayGround-3Plus
echo "# %repro%" >> README.md
git init
git add README.md
git config --global user.email "fdhorn2@gmx.de"
git config --global user.name "fdhorn2"
git commit -m "Initial commit"
git branch -M main
git remote add origin https://github.com/fdhorn2/%repro%.git
git push -u origin main


REM history
REM doskey /history
REM doskey /history >hist.txt
@echo on