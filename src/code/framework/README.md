### Shared Kernel Framework
This is a cross cutting concern set of libraries that represent shared models, e.g. shared kernels.

Ideally this framework should be semVer versioned+published as Nuget packages to be consumed by feature/domain teams. In this simplified implementation, we will use project references for other domains to use it.

Apart from a PostalAddress object, it contains only interfaces that can be implemented by other domains and that can be used in API Interface definitions.

One library should probably not contain all these disparate kernels contracts/interfaces but for simplicity they have been all included in this one library (not realistic though).

