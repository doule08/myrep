public static Class1 operator +(Class1 schoolClass, Class2 student)
{
  schoolClass[student.Name] = student;
  
  return schoolClass._Student.Count;
}

//on est obligé d'avoir un retour
// on écrit ce qu'on veut dans le code pour redéfinir l'opérateur. 
// on met que des opérateurs binaires surchargeables (arithmétiques, et autres ???)