using System;
using System.Collections.Generic;

class Patient
{
    public string Name { get; set; }
    public List<Doctor> Doctors { get; set; }  // List of doctors a patient consults

    public Patient(string name)
    {
        Name = name;
        Doctors = new List<Doctor>();
    }

    public void Consult(Doctor doctor)
    {
        if (!Doctors.Contains(doctor))
        {
            Doctors.Add(doctor);
            doctor.AddPatient(this);
            Console.WriteLine($"{Name} is now consulting Dr. {doctor.Name}.");
        }
        else
        {
            Console.WriteLine($"{Name} is already consulting Dr. {doctor.Name}.");
        }
    }

    public override string ToString()
    {
        return $"Patient: {Name}";
    }
}

class Doctor
{
    public string Name { get; set; }
    public List<Patient> Patients { get; set; }  // List of patients a doctor consults

    public Doctor(string name)
    {
        Name = name;
        Patients = new List<Patient>();
    }

    public void AddPatient(Patient patient)
    {
        if (!Patients.Contains(patient))
        {
            Patients.Add(patient);
        }
    }

    public void Consult(Patient patient)
    {
        if (Patients.Contains(patient))
        {
            Console.WriteLine($"Consultation between Dr. {Name} and {patient.Name}:");
            Console.WriteLine($"{patient.Name} is being examined by Dr. {Name}.");
        }
        else
        {
            Console.WriteLine($"Dr. {Name} has no record of consultation with {patient.Name}.");
        }
    }

    public override string ToString()
    {
        return $"Doctor: {Name}";
    }
}

class Hospital
{
    public string Name { get; set; }
    public List<Doctor> Doctors { get; set; }
    public List<Patient> Patients { get; set; }

    public Hospital(string name)
    {
        Name = name;
        Doctors = new List<Doctor>();
        Patients = new List<Patient>();
    }

    public void AddDoctor(Doctor doctor)
    {
        Doctors.Add(doctor);
    }

    public void AddPatient(Patient patient)
    {
        Patients.Add(patient);
    }

    public void ShowHospitalInfo()
    {
        Console.WriteLine($"Hospital: {Name}");
        Console.WriteLine("Doctors in the Hospital:");
        foreach (var doctor in Doctors)
        {
            Console.WriteLine(doctor);
        }
        Console.WriteLine("Patients in the Hospital:");
        foreach (var patient in Patients)
        {
            Console.WriteLine(patient);
        }
    }
}

class Program
{
    static void Main()
    {
        // Create hospital
        Hospital hospital = new Hospital("Nayati Hospital");

        // Create doctors
        Doctor doctor1 = new Doctor("Dr. Yugal");
        Doctor doctor2 = new Doctor("Dr. Shivang");

        // Add doctors to the hospital
        hospital.AddDoctor(doctor1);
        hospital.AddDoctor(doctor2);

        // Create patients
        Patient patient1 = new Patient("Chotu");
        Patient patient2 = new Patient("Neelanshu");

        // Add patients to the hospital
        hospital.AddPatient(patient1);
        hospital.AddPatient(patient2);

        // Patients consult doctors
        patient1.Consult(doctor1);
        patient1.Consult(doctor2);
        patient2.Consult(doctor1);

        // Show the hospital information (doctors and patients)
        hospital.ShowHospitalInfo();

        // Perform consultations
        doctor1.Consult(patient1);
        doctor2.Consult(patient1);
        doctor1.Consult(patient2);
    }
}