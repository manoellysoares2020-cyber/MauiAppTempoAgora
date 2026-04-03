using CommunityToolkit.Mvvm.Input;
using MauiAppTempoAgora.Models;

namespace MauiAppTempoAgora.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}