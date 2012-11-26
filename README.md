# Virtue

Virtue is a GitHub-oriented [continuous integration](http://en.wikipedia.org/wiki/Continuous_integration) bot. Use it to ensure all commits build properly, to test pull
requests, and more.

Among other things, here are some cool things Virtue can do for you:

* Build each new commit and update the status
* Build pull requests and update the status
* Bundle downloads when milestones are completed
* Run unit tests and ensure none fail

## Getting Started

Setting up Virtue is relatively easy. Grab the [latest version](#), or [read the instructions](#) on building it yourself. Run the following command to start Virtue and it
will help you create a configuration file. You can delete your configuration file or use `--setup` to run this again later.

**Windows**

    Virtue.exe

**Linux/Mac**

You'll need to have [Mono](http://monoproject.org) installed first. It'd also probably be good to run this in a GNU screen or the like.

    mono Virtue.exe