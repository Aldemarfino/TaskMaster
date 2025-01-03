﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Project:IEntityOptions
    {
        public int IdProject { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Deadline { get; set; }
        public string State { get; set; }
        public int Percentage { get; set; }
        public byte[] FileContent { get; set; }
        public User CreatorUser { get; set; }

        public Project(){}

        public Project(string name, string description, DateTime startDate, DateTime deadline,
            string state, int percentage, byte[] fileContent, User creatorUser)
        {
            Name = name;
            Description = description;
            StartDate = startDate;
            Deadline = deadline;
            State = state;
            Percentage = percentage;
            FileContent = fileContent;
            CreatorUser = creatorUser;
        }

        public Project(int idProject, string name, string description, DateTime startDate, 
            DateTime deadline, string state, int percentage, byte[] fileContent, User creatorUser)
        {
            IdProject = idProject;
            Name = name;
            Description = description;
            StartDate = startDate;
            Deadline = deadline;
            State = state;
            Percentage = percentage;
            FileContent = fileContent;
            CreatorUser = creatorUser;
        }

        public SqlCommand SQLCommandInsert(SqlConnection connection)
        {
            string ssql = "INSERT INTO Proyectos([Nombre],[Descripcion],[Fecha_Inicio],[Fecha_Limite],[Estado],[Porcentaje],[Archivo],[Usuario_Creador])" +
                   "VALUES (@Nombre, @Descripcion, @Fecha_Inicio, @Fecha_Limite, @Estado, @Porcentaje, @Archivo, @Usuario_Creador)";
            SqlCommand cmd = new SqlCommand(ssql, connection);
            cmd.Parameters.AddWithValue("@Nombre", Name);
            cmd.Parameters.AddWithValue("@Descripcion", Description);
            cmd.Parameters.AddWithValue("@Fecha_Inicio", StartDate);
            cmd.Parameters.AddWithValue("@Fecha_Limite", Deadline);
            cmd.Parameters.AddWithValue("@Estado", State);
            cmd.Parameters.AddWithValue("@Porcentaje", 0);
            cmd.Parameters.Add("@Archivo", SqlDbType.VarBinary).Value = (FileContent != null) ? FileContent : (object)DBNull.Value;
            cmd.Parameters.AddWithValue("@Usuario_Creador", CreatorUser.UserName);
            return cmd;
        }
    }
}
