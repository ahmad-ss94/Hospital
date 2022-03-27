﻿using System.Net;
using Hospital.Application.Interfaces;
using Hospital.Application.Models.Patient;
using Hospital.Application.Parameters.Patient;
using Hospital.Application.Results;
using Hospital.Application.Results.Patient;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.API.Controllers
{
    public class PatientController : BaseController
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpPost(nameof(CreatePatient))]
        [ProducesResponseType(typeof(Response<PatientResult>), StatusCodes.Status200OK)]
        public async Task<IActionResult> CreatePatient([FromBody] PatientModel model)
        {
            var result = await _patientService.CreatePatient(model);

            return result.Status switch
            {
                nameof(HttpStatusCode.OK) => Ok(result),
                _ => BadRequest(result.Message)
            };
        }

        [HttpPatch(nameof(UpdatePatient))]
        [ProducesResponseType(typeof(Response<PatientResult>), StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdatePatient([FromBody] PatientModel model)
        {
            var result = await _patientService.UpdatePatient(model);

            return result.Status switch
            {
                nameof(HttpStatusCode.OK) => Ok(result),
                _ => BadRequest(result.Message)
            };
        }

        [HttpGet(nameof(GetPatients)), AllowAnonymous]
        [ProducesResponseType(typeof(PagedResponse<List<PatientResult>>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPatients([FromQuery] GetAllPatientParameter parameter)
        {
            var result = await _patientService.GetPatients(parameter);

            return result.Status switch
            {
                nameof(HttpStatusCode.OK) => Ok(result),
                _ => BadRequest(result.Message)
            };
        }

        [HttpPost(nameof(CreatePatientRecord))]
        [ProducesResponseType(typeof(Response<PatientRecordResult>), StatusCodes.Status200OK)]
        public async Task<IActionResult> CreatePatientRecord([FromBody] PatientRecordModel model)
        {
            var result = await _patientService.CreatePatientRecord(model);

            return result.Status switch
            {
                nameof(HttpStatusCode.OK) => Ok(result),
                _ => BadRequest(result.Message)
            };
        }

        [HttpPost(nameof(AddSampleData)), AllowAnonymous]
        [ProducesResponseType(typeof(Response<string>), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddSampleData()
        {
            var result = await _patientService.AddSampleData();

            return result.Status switch
            {
                nameof(HttpStatusCode.OK) => Ok(result),
                _ => BadRequest(result.Message)
            };
        }

    }
}
