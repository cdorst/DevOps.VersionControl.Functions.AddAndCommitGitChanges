using static DevOps.VersionControl.Functions.RunGitAddCommand.GitAddCommandRunner;
using static DevOps.VersionControl.Functions.RunGitCommitCommand.GitCommitCommandRunner;
using static DevOps.VersionControl.Functions.SetGitRepositoryUserInfo.UserInfoSetter;

namespace DevOps.VersionControl.Functions.AddAndCommitGitChanges
{
    public static class GitChangeAdderAndCommitter
    {
        public static void AddAndCommitChanges(string repositoryDirectory, string message, UserInfo? userInfo = null)
        {
            if (userInfo != null)
                SetUserInfo(repositoryDirectory,
                    userInfo.Value.Name,
                    userInfo.Value.Email);
            Add(repositoryDirectory);
            Commit(repositoryDirectory, message);
        }
    }
}
