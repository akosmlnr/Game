using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x02000441 RID: 1089
	public class DarkMarketRollerDoors : SensorRollerDoors
	{
		// Token: 0x06005EDE RID: 24286 RVA: 0x001B80AC File Offset: 0x001B62AC
		// Note: this type is marked as 'beforefieldinit'.
		static DarkMarketRollerDoors()
		{
			Il2CppClassPointerStore<DarkMarketRollerDoors>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "DarkMarketRollerDoors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DarkMarketRollerDoors>.NativeClassPtr);
			DarkMarketRollerDoors.NativeMethodInfoPtr_CanOpen_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketRollerDoors>.NativeClassPtr, 100675481);
			DarkMarketRollerDoors.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketRollerDoors>.NativeClassPtr, 100675482);
		}

		// Token: 0x06005EDF RID: 24287 RVA: 0x001B8104 File Offset: 0x001B6304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200072, XrefRangeEnd = 200076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DarkMarketRollerDoors.NativeMethodInfoPtr_CanOpen_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005EE0 RID: 24288 RVA: 0x001B814C File Offset: 0x001B634C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200076, XrefRangeEnd = 200079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DarkMarketRollerDoors() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DarkMarketRollerDoors>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketRollerDoors.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EE1 RID: 24289 RVA: 0x0002C7E2 File Offset: 0x0002A9E2
		public DarkMarketRollerDoors(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040040E9 RID: 16617
		private static readonly IntPtr NativeMethodInfoPtr_CanOpen_Protected_Virtual_Boolean_0;

		// Token: 0x040040EA RID: 16618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
