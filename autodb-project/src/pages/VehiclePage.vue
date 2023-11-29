<template>
  <div class="text-center">
    <div class="text-h2 q-mt-lg">Vehicles</div>
    <div class="text-h3 q-mt-lg">{{ state.status }}</div>
    <div class="q-pa-md">
      <div class="q-ma-md row flex-center">
        <q-select
          clearable
          v-model="selectedManu"
          :options="state.manufacturers"
          label="Manufacturers"
          style="width: 250px"
          outlined
        />

        <q-select
          clearable
          v-model="selectedBodyStyle"
          :options="state.bodystyles"
          label="Body Style"
          style="width: 250px"
          outlined
        />
      </div>
      <div class="q-ma-md row flex-center">
        <q-btn
          color="white"
          text-color="black"
          label="Enter"
          style="width: 200px"
          @click="loadTable()"
        />
        <q-btn
          color="primary"
          label="Clear"
          style="width: 200px"
          @click.stop.prevent="
            selectedManu = null;
            selectedModel = null;
            selectedBodyStyle = null;
            clearTable();
          "
        />
      </div>
    </div>
    <q-scroll-area style="height: 35vh">
      <q-card class="q-ma-md" id="testcard">
        <q-list separator>
          <q-item class>
            <q-item-section class="text-center"> Manufacturer </q-item-section>
            <q-item-section class="text-center"> Model </q-item-section>
            <q-item-section class="text-center"> Body Style </q-item-section>
          </q-item>
          <q-item v-for="item in state.vehicles" :key="item.manufacturerName">
            <q-item-section class="text-center">
              {{ item.manufacturerName }}
            </q-item-section>
            <q-item-section class="text-center">
              {{ item.modelName }}
            </q-item-section>
            <q-item-section class="text-center">
              {{ item.bodyStyle }}
            </q-item-section>
          </q-item>
        </q-list>
      </q-card>
    </q-scroll-area>
  </div>
</template>

<script>
import { fetcher } from "../utils/apiutil";
import { reactive, onMounted, ref } from "vue";

export default {
  setup() {
    onMounted(() => {
      loadManufacturer();
      loadModels();
      loadBodyStyles();
    });

    let state = reactive({
      status: "",
      vehicles: [],
      manufacturerList: [],
      manufacturers: [],
      bodyList: [],
      bodystyles: [],
      modelList: [],
      models: [],
    });
    const clearTable = () => {
      var card = document.getElementById("testcard");
      card.hidden = true;
    };

    const loadTable = async () => {
      var card = document.getElementById("testcard");
      card.hidden = false;
      loadVehicles();
    };

    const loadVehicles = async () => {
      try {
        state.vehicles = await fetcher(`Vehicle`);
      } catch (err) {
        console.log(err);
        state.status = `Error has occured: ${err.message}`;
      }
    };

    const loadManufacturer = async () => {
      try {
        state.manufacturerList = await fetcher(`Manufacturer`);
        for (var key in state.manufacturerList) {
          state.manufacturers.push(
            state.manufacturerList[key].manufacturerName
          );
        }
      } catch (err) {
        console.log(err);
        state.status = `Error has occured: ${err.message}`;
      }
    };
    const loadModels = async () => {
      try {
        state.modelList = await fetcher(`Model`);
        for (var key in state.modelList) {
          state.models.push(state.modelList[key].modelName);
        }
      } catch (err) {
        console.log(err);
        state.status = `Error has occured: ${err.message}`;
      }
    };
    const loadBodyStyles = async () => {
      try {
        state.bodyList = await fetcher(`BodyStyle`);
        for (var key in state.bodyList) {
          state.bodystyles.push(state.bodyList[key].bodyStyle);
        }
      } catch (err) {
        console.log(err);
        state.status = `Error has occured: ${err.message}`;
      }
    };
    return {
      state,
      loadVehicles,
      loadManufacturer,
      loadModels,
      loadBodyStyles,
      clearTable,
      loadTable,
      selectedManu: ref(null),
      selectedModel: ref(null),
      selectedBodyStyle: ref(null),
    };
  },
};
</script>
