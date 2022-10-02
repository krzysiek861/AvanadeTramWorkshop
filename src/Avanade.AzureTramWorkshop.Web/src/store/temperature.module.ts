export default {
    namespaced: true,
    state: {
        air: 20,
        engine: 50,
        inverter: 35
    },
    mutations: {
        UPDATE_AIR_TEMPERATURE(state : any, payload : number) {
            state.air = payload
        },
        UPDATE_ENGINE_TEMPERATURE(state : any, payload : number) {
            state.engine = payload
        },
        UPDATE_INVERTER_TEMPERATURE(state : any, payload : number) {
            state.inverter = payload
        }
    },
    actions : {
        updateAirTemperature(context : any, payload : number) {
            context.commit('UPDATE_AIR_TEMPERATURE', payload)
        },
        updateEngineTemperature(context : any, payload : number) {
            context.commit('UPDATE_ENGINE_TEMPERATURE', payload)
        },
        updateInverterTemperature(context : any, payload : number) {
            context.commit('UPDATE_INVERTER_TEMPERATURE', payload)
        }
    }
}