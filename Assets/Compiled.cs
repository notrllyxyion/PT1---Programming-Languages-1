using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compiled : MonoBehaviour
{
   public InputField studentIDinput;
   public Text ResultText;

    public class Students
    {
        public string studentName;
       public  string studentbirthdate;
        public int Age; 
    }
    Dictionary<string , Students > studentID = new Dictionary<string, Students >();
    public void Values()
    {
        studentID.Add("24-668", new Students { studentName = "Adora, Christian Mateo Perez ", studentbirthdate = "June 7, 2008" , Age = 17});
        studentID.Add("24668", new Students { studentName = "Adora, Christian Mateo Perez ", studentbirthdate = "June 7, 2008", Age = 17 });
        studentID.Add("24-727", new Students { studentName = "Baja, Feliz Salazar", studentbirthdate = "March 5, 2007", Age = 18 });
        studentID.Add("24727", new Students { studentName = "Baja, Feliz Salazar", studentbirthdate = "March 5, 2007", Age = 18 });
        studentID.Add("24-669", new Students { studentName = "Siruno, Andrei Bautista", studentbirthdate = "July 3, 2008", Age = 16 });
        studentID.Add("24669", new Students { studentName = "Siruno, Andrei Bautista", studentbirthdate = "July 3, 2008", Age = 16 });
        studentID.Add("24-756", new Students { studentName = "Escuadra, Floyd Francisco", studentbirthdate = "December 19, 2007", Age = 17 });
        studentID.Add("24756", new Students { studentName = "Escuadra, Floyd Francisco", studentbirthdate = "December 19, 2007", Age = 17 });
        studentID.Add("24-744", new Students { studentName = "Esquivel, Jon Miguel Valeroso", studentbirthdate = "June 28, 2008", Age = 16 });
        studentID.Add("24744", new Students { studentName = "Esquivel, Jon Miguel Valeroso", studentbirthdate = "June 28, 2008", Age = 16 });
    }
    public void Start()
    {
        Values();
    }
    public void OnClick()
    {
        string InputID = studentIDinput.text;

        if (studentID.ContainsKey(InputID))
        {
           Students student = studentID[InputID];
           ResultText.text = $"Student Name: {student.studentName} \r\n Birthday: {student.studentbirthdate} \r\n Age: {student.Age} ";            
        }
        else
        {
            ResultText.text = "No Student found";
        }
    }   
}

