CREATE DATABASE SweeftDB;

--დაწერეთ sql რომელიც ააგებს შესაბამის table-ებს.
CREATE TABLE Teacher (
  teacher_id INT PRIMARY KEY,
  name VARCHAR(50),
  surname VARCHAR(50),
  gender VARCHAR(10),
  subject VARCHAR(50)
);

CREATE TABLE Pupil (
  pupil_id INT PRIMARY KEY,
  name VARCHAR(50),
  surname VARCHAR(50),
  gender VARCHAR(10),
  class VARCHAR(50)
);

CREATE TABLE Teacher_Pupil (
  teacher_id INT,
  pupil_id INT,
  PRIMARY KEY (teacher_id, pupil_id),
  FOREIGN KEY (teacher_id) REFERENCES Teacher(teacher_id),
  FOREIGN KEY (pupil_id) REFERENCES Pupil(pupil_id)
);

INSERT INTO Teacher (teacher_id, name, surname, gender, subject)
VALUES (1, 'John', 'Smith', 'Male', 'Math');

INSERT INTO Pupil (pupil_id, name, surname, gender, class)
VALUES (1, 'Giorgi', 'Johnson', 'Female', 'Grade 7');

INSERT INTO Pupil (pupil_id, name, surname, gender, class)
VALUES (2, 'Jack', 'Davis', 'Male', 'Grade 7');

INSERT INTO Teacher_Pupil (teacher_id, pupil_id)
VALUES (1, 1);

INSERT INTO Teacher_Pupil (teacher_id, pupil_id)
VALUES (1, 2);

--დაწერეთ sql რომელიც დააბრუნებს ყველა მასწავლებელს, რომელიც
--ასწავლის მოსწავლეს, რომელის სახელია: „გიორგი“
SELECT t.name, t.surname
FROM Teacher t
INNER JOIN Teacher_Pupil tp ON t.teacher_id = tp.teacher_id
INNER JOIN Pupil p ON tp.pupil_id = p.pupil_id
WHERE p.name = 'Giorgi';
