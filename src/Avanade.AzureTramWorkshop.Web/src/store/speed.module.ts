export default {
    namespaced: true,
    state: {
        tram: 0,
        wheels: 23
    },
    getters: {
        isSlip: function (state: any) {
            const wheelRadiusMeters = 0.6;
            const speedTramMetersPerSecond = state.tram / 3.6;
            const expectedWheelSpeed = speedTramMetersPerSecond / wheelRadiusMeters;

            // Detect slip event when the difference is greater than 1 m/s.
            return Math.abs(expectedWheelSpeed - state.wheels) > 1;
        },
        tramSpeed: function (state: any) {
            return state.tram;
        },
        tramSpeedArrow : function (state: any) {
            const speedToDegreesBy5 = [-20, -5, 10, 23, 35.5, 50, 62, 77, 90.5, 105, 119];
            const index = Math.floor(state.tram / 5);
            const remainder = state.tram % 5;
            const speedChangeFactor = remainder / 5;

            return remainder > 0
                ? `${speedToDegreesBy5[index] + ((speedToDegreesBy5[index + 1] - speedToDegreesBy5[index]) * speedChangeFactor)}deg`
                : `${speedToDegreesBy5[index]}deg`
        },
        wheelSpeed: function(state: any) {
            return state.wheels
        },
        wheelSpeedArrow : function (state: any) {
            const speedToDegreesBy5 = [0, 15, 30, 44, 58.5, 74, 89, 104, 118.5, 133, 148, 162, 175, 180];
            const index = Math.floor(state.wheels / 5);
            const remainder = state.wheels % 5;
            const speedChangeFactor = remainder / 5;

            return remainder > 0
                ? `${speedToDegreesBy5[index] + ((speedToDegreesBy5[index + 1] - speedToDegreesBy5[index]) * speedChangeFactor)}deg`
                : `${speedToDegreesBy5[index]}deg`
        },
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