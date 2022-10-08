export default {
    namespaced: true,
    state: {
        air: 0,
        engine: 0,
        inverter: 0
    },
    getters: {
        air : function (state: any) {
            return state.air;
        },
        airGradientWidth: function (state: any) {
            return calculateGradient(-5, 30, state.air);
        },
        engine: function (state: any) {
            return state.engine;
        },
        engineGradientWidth: function (state: any) {
            return calculateGradient(50, 130, state.engine);
        },
        inverter : function (state: any) {
            return state.inverter;
        },
        inverterGradientWidth: function (state: any) {
            return calculateGradient(20, 80, state.inverter);
        }
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

function calculateGradient(min: number, max: number, value: number) : number {
    const minWidthPx = 10;
    const maxWidthPx = 233;
    const width = maxWidthPx - (maxWidthPx * (max - value) / (max - min));
    
    if (width < minWidthPx) {
        return minWidthPx;
    } else if (width > maxWidthPx) {
        return maxWidthPx;
    }

    return width;
}