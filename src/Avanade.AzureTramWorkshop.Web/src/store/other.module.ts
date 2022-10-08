export default {
    namespaced: true,
    state: {
        smoke: false,
        light: false
    },
    getters: {
        smoke : function (state: any) {
            return state.smoke;
        },
        light : function (state: any) {
            return state.light;
        }
    },
    mutations: {
        UPDATE_SMOKE(state : any, payload : number) {
            state.air = payload
        },
        UPDATE_LIGHT(state : any, payload : number) {
            state.inverter = payload
        }
    },
    actions : {
        updateSmokeSensor(context : any, payload : number) {
            context.commit('UPDATE_SMOKE', payload)
        },
        updateLightSenson(context : any, payload : number) {
            context.commit('UPDATE_LIGHT', payload)
        }
    }
}