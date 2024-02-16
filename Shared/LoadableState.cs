namespace FluxorSyncfusionGrid.Shared
{
    public abstract record OrderLoadableState
    {
        public bool IsLoading { get; init; }
        public bool HasError { get; init; }
        public string ErrorMessage { get; init; }
    }
}