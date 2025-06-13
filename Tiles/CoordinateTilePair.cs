using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x020001A1 RID: 417
	[System.Serializable]
	public sealed class CoordinateTilePair : Il2CppSystem.ValueType
	{
		// Token: 0x06002211 RID: 8721 RVA: 0x000DE1F8 File Offset: 0x000DC3F8
		// Note: this type is marked as 'beforefieldinit'.
		static CoordinateTilePair()
		{
			Il2CppClassPointerStore<CoordinateTilePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "CoordinateTilePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoordinateTilePair>.NativeClassPtr);
			CoordinateTilePair.NativeFieldInfoPtr_coord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateTilePair>.NativeClassPtr, "coord");
			CoordinateTilePair.NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateTilePair>.NativeClassPtr, "tile");
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x00012DE3 File Offset: 0x00010FE3
		public CoordinateTilePair(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x00012DEC File Offset: 0x00010FEC
		public CoordinateTilePair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoordinateTilePair>.NativeClassPtr))
		{
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06002214 RID: 8724 RVA: 0x000DE250 File Offset: 0x000DC450
		// (set) Token: 0x06002215 RID: 8725 RVA: 0x00012DFE File Offset: 0x00010FFE
		public unsafe Coordinate coord
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateTilePair.NativeFieldInfoPtr_coord);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateTilePair.NativeFieldInfoPtr_coord), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x000DE280 File Offset: 0x000DC480
		// (set) Token: 0x06002217 RID: 8727 RVA: 0x00012E1D File Offset: 0x0001101D
		public unsafe Tile tile
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateTilePair.NativeFieldInfoPtr_tile);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateTilePair.NativeFieldInfoPtr_tile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016B6 RID: 5814
		private static readonly System.IntPtr NativeFieldInfoPtr_coord;

		// Token: 0x040016B7 RID: 5815
		private static readonly System.IntPtr NativeFieldInfoPtr_tile;
	}
}
