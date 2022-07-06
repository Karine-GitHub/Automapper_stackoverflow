using AutoMapper;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Oncolin.Entities;
using Oncolin.Model.Oncology;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace AutoMapper_Stackoverflow
{
    public class Worker : IHostedService
    {
        private readonly IServiceProvider _provider = null;
        private readonly ILogger _logger = null;
        private readonly IMapper _mapper = null;
        private readonly JsonSerializerSettings _loopSerializerSettings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Objects,
            TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Full,
            PreserveReferencesHandling = PreserveReferencesHandling.All,
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        public Worker(
            IServiceProvider provider,
            ILogger<Worker> logger,
            IMapper mapper)
        {
            _provider = provider;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await LoadData("data.json");
            await LoadData("invalidData.json");
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("StopAsync has been called.");
            return Task.CompletedTask;
        }

        private async Task LoadData(string fileName)
        {
            try
            {
                _logger.LogInformation($"Load data from '{fileName}'");

                var json = await File.ReadAllTextAsync(Path.Combine(AppContext.BaseDirectory, fileName));
                var entity = JsonConvert.DeserializeObject<ClinicalPatientData>(json, _loopSerializerSettings);

                _logger.LogInformation($"Create patient model");
                var model = _mapper.Map<Patient>(entity);
                _logger.LogInformation($"Create patient model2");
                var model2 = new Patient();
                _mapper.Map(entity, model2);

                _logger.LogInformation($"Create tumors model");
                var tumors = new System.Collections.ObjectModel.ObservableCollection<Tumor>();
                _mapper.Map(entity.Tumors, tumors);

                _logger.LogInformation($"Create tumors entities"); 
                var tumorEntities = new List<TumorEntity>();
                _mapper.Map(tumors, tumorEntities);

                _logger.LogInformation($"Load data from '{fileName}' success");
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Load data in file '{fileName}' failed with error : {e.Message}");
                throw;
            }

        }
    }
}