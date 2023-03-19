using SchoolEF;

var dbContext = new SchoolEFContext();

dbContext.Database.EnsureCreated();

var teacherService = new TeacherService(dbContext);

var teachersByStudent = teacherService.GetAllTeachersByStudent("Giorgi");

Console.WriteLine(teachersByStudent.Length);

//dbContext.Database.EnsureDeleted();


