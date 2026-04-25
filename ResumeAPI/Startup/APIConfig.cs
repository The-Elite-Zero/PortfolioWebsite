namespace ResumeAPI.Startup
{
    public static class APIConfig
    {
        public static void UseAPIConfig(this WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
        }
    }
}
