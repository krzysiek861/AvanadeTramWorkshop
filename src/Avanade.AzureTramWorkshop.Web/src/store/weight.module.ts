export default {
    namespaced: true,
    state: {
        weight: 7000
    },
    getters: {
        weightInTons: function (state : any) {
            // Change kilograms to tons.
            return (state.weight / 1000).toFixed(1);
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