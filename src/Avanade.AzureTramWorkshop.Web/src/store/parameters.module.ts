export default {
    namespaced: true,
    state: {
        current: 0,
        battery: 0,
        traction: 0,
        weight: 0
    },
    getters: {
        powerConsumption: function (state : any) {
            return state.current;
        },
        batteryVoltage: function (state : any) {
            return state.battery;
        },
        tractionVoltage: function (state : any) {
            return state.traction;
        },
        weightInTons: function (state : any) {
            // Change kilograms to tons.
            return (state.weight / 1000).toFixed(0);
        }
    },
    mutations: {
        UPDATE_WEIGHT(state : any, payload : number) {
            state.weight = payload
          }
    },
    actions : {
        updateWeight(context : any, payload : number) {
            context.commit('UPDATE_WEIGHT', payload)
        }
    }
  }