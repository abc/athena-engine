SET /P COMMIT="Please enter a commit message: "
git add .
git commit -a -m %commit%