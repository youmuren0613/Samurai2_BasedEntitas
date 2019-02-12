

namespace Game
{
    /// <summary>
    /// 基础行为接口
    /// </summary>
    public interface IBehaviour
    {
        void Idle();
        void Forward();
        void Back();
        void Left();
        void Right();
    }

    /// <summary>
    /// 玩家行为接口
    /// </summary>
    public interface IPlayerBehaviour : IBehaviour
    {
        /// <summary>
        /// 当前是否在跑标志位
        /// </summary>
        bool IsRun { get; set; }

        /// <summary>
        /// 攻击键
        /// </summary>
        void Attack(int skillCode);
    }
}
