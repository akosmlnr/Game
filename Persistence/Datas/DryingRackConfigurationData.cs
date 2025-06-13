using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000292 RID: 658
	[Serializable]
	public class DryingRackConfigurationData : SaveData
	{
		// Token: 0x060030D8 RID: 12504 RVA: 0x0010F9F4 File Offset: 0x0010DBF4
		// Note: this type is marked as 'beforefieldinit'.
		static DryingRackConfigurationData()
		{
			Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DryingRackConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr);
			DryingRackConfigurationData.NativeFieldInfoPtr_TargetQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr, "TargetQuality");
			DryingRackConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr, "Destination");
			DryingRackConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_QualityFieldData_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr, 100669023);
		}

		// Token: 0x060030D9 RID: 12505 RVA: 0x0010FA60 File Offset: 0x0010DC60
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 136250, RefRangeEnd = 136261, XrefRangeStart = 136250, XrefRangeEnd = 136261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRackConfigurationData(QualityFieldData targetquality, ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetquality);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_QualityFieldData_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060030DA RID: 12506 RVA: 0x000199F0 File Offset: 0x00017BF0
		public DryingRackConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x060030DB RID: 12507 RVA: 0x0010FAC0 File Offset: 0x0010DCC0
		// (set) Token: 0x060030DC RID: 12508 RVA: 0x000199F9 File Offset: 0x00017BF9
		public unsafe QualityFieldData TargetQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigurationData.NativeFieldInfoPtr_TargetQuality);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigurationData.NativeFieldInfoPtr_TargetQuality), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x060030DD RID: 12509 RVA: 0x0010FAF0 File Offset: 0x0010DCF0
		// (set) Token: 0x060030DE RID: 12510 RVA: 0x00019A18 File Offset: 0x00017C18
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400202C RID: 8236
		private static readonly IntPtr NativeFieldInfoPtr_TargetQuality;

		// Token: 0x0400202D RID: 8237
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x0400202E RID: 8238
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_QualityFieldData_ObjectFieldData_0;
	}
}
