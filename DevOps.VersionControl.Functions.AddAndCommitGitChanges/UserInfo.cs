namespace DevOps.VersionControl.Functions.AddAndCommitGitChanges
{
    public struct UserInfo
    {
        public UserInfo(string email, string name)
        {
            Email = email;
            Name = name;
        }

        public string Email { get; set; }
        public string Name { get; set; }
    }
}
