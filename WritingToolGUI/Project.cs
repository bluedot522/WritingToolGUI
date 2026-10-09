using System;
using System.Collections.Generic;
using System.Text;

namespace WritingToolGUI
{
    public class Project : Item
    {
        public static List<Project> projectList = new List<Project>();
        public static void AddProject(string name, string description, List<string> tags)
        {
            projectList.Add(new Project { Name = name, Description = description, Tags = tags });
        }

        public static void RemoveProject(Project project)
        {
            projectList.Remove(project);
        }

        public static void EditProject(Project project, string newName, string newDescription, List<string> newTags)
        {
            project.Name = newName;
            project.Description = newDescription;
            project.Tags = newTags;
        }
    }
}
