﻿using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations
{
    public class ProjectService : IProjectService
    {
        private readonly DevFreelaDbContext _dbcontext;

        public ProjectService(DevFreelaDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public int Create(NewProjectInputModel inputModel)
        {
            var project = new Project(inputModel.Title, inputModel.Description, inputModel.IdClient, inputModel.IdFreelancer, inputModel.TotalCost);
            _dbcontext.Projects.Add(project);
            return project.Id;
        }

        public void CreateComment(CreateCommentInputModel inputModel)
        {
            var projectComment = new ProjectComment(inputModel.Content, inputModel.IdProject, inputModel.IdUser);
            _dbcontext.ProjectComments.Add(projectComment);
        }

        public void Delete(int id)
        {
            var project = _dbcontext.Projects.SingleOrDefault(p => p.Id == id);
            project.Cancel();
            //_dbcontext.Projects.RemoveAt(id);
        }

        public void Finish(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProjectViewModel> GetAll(string query)
        {
            var projects = _dbcontext.Projects;
            var projectsViewModel = projects
                .Select(p => new ProjectViewModel(p.Title, p.CreatedAt))
                .ToList();
            return projectsViewModel;
        }

        public ProjectDetailsViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Start(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UpdateProjectInputModel inputModel)
        {
            throw new NotImplementedException();
        }
    }
}
