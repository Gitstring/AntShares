﻿namespace AntShares.Implementations.Blockchains.LevelDB
{
    internal enum DataEntryPrefix : byte
    {
        /// <summary>
        /// 区块头表
        /// </summary>
        DATA_HeaderList = 0x00,

        /// <summary>
        /// 区块
        /// </summary>
        DATA_Block = 0x01,

        /// <summary>
        /// 交易
        /// </summary>
        DATA_Transaction = 0x02,

        /// <summary>
        /// 当前区块，区块链的当前状态（包括所有的索引、统计信息）由该区块以及所有的前置区块共同决定
        /// </summary>
        SYS_CurrentBlock = 0x40,

        /// <summary>
        /// 资产索引
        /// </summary>
        IX_Asset = 0x81,

        /// <summary>
        /// 候选人索引
        /// </summary>
        IX_Enrollment = 0x84,

        /// <summary>
        /// 未花费索引
        /// </summary>
        IX_Unspent = 0x90,

        /// <summary>
        /// 未领取小蚁币的小蚁股
        /// </summary>
        IX_Unclaimed = 0x91,

        /// <summary>
        /// 选票索引
        /// </summary>
        IX_Vote = 0x94,

        /// <summary>
        /// 资产的已发行量
        /// </summary>
        ST_QuantityIssued = 0xc1,

        /// <summary>
        /// 数据库版本
        /// </summary>
        CFG_Version = 0xf0,
    }
}
