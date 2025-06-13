using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000295 RID: 661
	[Serializable]
	public class MixingStationConfigurationData : SaveData
	{
		// Token: 0x060030E9 RID: 12521 RVA: 0x0010FCC0 File Offset: 0x0010DEC0
		// Note: this type is marked as 'beforefieldinit'.
		static MixingStationConfigurationData()
		{
			Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MixingStationConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr);
			MixingStationConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr, "Destination");
			MixingStationConfigurationData.NativeFieldInfoPtr_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr, "Threshold");
			MixingStationConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_NumberFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr, 100669026);
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x0010FD2C File Offset: 0x0010DF2C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 136250, RefRangeEnd = 136261, XrefRangeStart = 136250, XrefRangeEnd = 136261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixingStationConfigurationData(ObjectFieldData destination, NumberFieldData threshold) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(threshold);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_NumberFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060030EB RID: 12523 RVA: 0x00019A87 File Offset: 0x00017C87
		public MixingStationConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x060030EC RID: 12524 RVA: 0x0010FD8C File Offset: 0x0010DF8C
		// (set) Token: 0x060030ED RID: 12525 RVA: 0x00019A90 File Offset: 0x00017C90
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x060030EE RID: 12526 RVA: 0x0010FDBC File Offset: 0x0010DFBC
		// (set) Token: 0x060030EF RID: 12527 RVA: 0x00019AAF File Offset: 0x00017CAF
		public unsafe NumberFieldData Threshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigurationData.NativeFieldInfoPtr_Threshold);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigurationData.NativeFieldInfoPtr_Threshold), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002033 RID: 8243
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04002034 RID: 8244
		private static readonly IntPtr NativeFieldInfoPtr_Threshold;

		// Token: 0x04002035 RID: 8245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_NumberFieldData_0;
	}
}
