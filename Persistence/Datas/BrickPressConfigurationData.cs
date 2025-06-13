using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200028D RID: 653
	[Serializable]
	public class BrickPressConfigurationData : SaveData
	{
		// Token: 0x060030B9 RID: 12473 RVA: 0x0010F4C8 File Offset: 0x0010D6C8
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressConfigurationData()
		{
			Il2CppClassPointerStore<BrickPressConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "BrickPressConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressConfigurationData>.NativeClassPtr);
			BrickPressConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressConfigurationData>.NativeClassPtr, "Destination");
			BrickPressConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressConfigurationData>.NativeClassPtr, 100669018);
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x0010F520 File Offset: 0x0010D720
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 136201, RefRangeEnd = 136212, XrefRangeStart = 136201, XrefRangeEnd = 136212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressConfigurationData(ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x000198CB File Offset: 0x00017ACB
		public BrickPressConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x060030BC RID: 12476 RVA: 0x0010F56C File Offset: 0x0010D76C
		// (set) Token: 0x060030BD RID: 12477 RVA: 0x000198D4 File Offset: 0x00017AD4
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400201F RID: 8223
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04002020 RID: 8224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0;
	}
}
