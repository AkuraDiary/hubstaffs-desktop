using HubstafDesktop.Data.Model.Response;
using HubstafDesktop.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubstafDesktop.Data.Model
{
    public static class DataMapper
    {
        public static UserTask MapTaskResponseToUserTask(TaskResponse taskResponse)
        {
            return new UserTask(
                taskResponse.Id,
                taskResponse.Name,
                taskResponse.Description,
                TimerUtil.parseStringTimeIntoAFuckingInteger(taskResponse.TimeNeeded),
                taskResponse.CreatedAt.ToString(),
                taskResponse.Status
                );
        }

        public static List<UserTask> MapListTaskResponseToListUserTask(List<TaskResponse> taskListResponse)
        {
            List<UserTask> userTaskList = new List<UserTask>();

            foreach (TaskResponse taskResponse in taskListResponse)
            {
                UserTask userTask = MapTaskResponseToUserTask(taskResponse);
                userTaskList.Add(userTask);
            }
            return userTaskList;
        }

        public static UserProject MapProjectResponseToUserProject(ProjectResponse projectResponse, List<UserTask> tasks)
        {
            return new UserProject(
                projectResponse.Id,
                projectResponse.Name,
                tasks,
                projectResponse.Timespan,
                projectResponse.OrganizationId
                );
        }

        public static List<UserProject> MapListProjectResponseToListUserProject(List<ProjectResponse> projectResponseList)
        {
            List<UserProject> userProjectList = new List<UserProject>();

            foreach (ProjectResponse projectItem in projectResponseList)
            {
                List<TaskResponse> taskListResponse = projectItem.Tasks;
                var userTaskData = DataMapper.MapListTaskResponseToListUserTask(taskListResponse);
                var UserProjectItem = DataMapper.MapProjectResponseToUserProject(projectItem, userTaskData);

                userProjectList.Add(UserProjectItem);
            }
            return userProjectList;
        }
    }
}
