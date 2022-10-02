export default {
    namespaced: true,
    state: {
        tram: 0,
        wheels: 0
    },
    getters: {
        slip: function (state: any) {
            // Simple slip formula.
            if (state.wheels > 0) {
                return state.tram / state.wheels < 0.5;
            }
            return false;
        },
        tramSpeed: function (state: any) {
            return state.tram;
        }
    },
    mutations: {
        UPDATE_TRAM_SPEED(state: any, payload: number) {
            state.tram = payload
          },
          UPDATE_WHEELS_SPEED(state: any, payload: number) {
            state.wheels = payload
          }
    },
    actions : {
        updateTramSpeed(context: any, payload: number) {
            context.commit('UPDATE_TRAM_SPEED', payload);
        },
        updateWheelsSpeed(context: any, payload: number) {
            context.commit('UPDATE_WHEELS_SPEED', payload);
        }
    }
}