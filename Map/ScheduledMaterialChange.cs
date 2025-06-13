using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020007B2 RID: 1970
	public class ScheduledMaterialChange : MonoBehaviour
	{
		// Token: 0x0600BA4F RID: 47695 RVA: 0x002E6F28 File Offset: 0x002E5128
		// Note: this type is marked as 'beforefieldinit'.
		static ScheduledMaterialChange()
		{
			Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "ScheduledMaterialChange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr);
			ScheduledMaterialChange.NativeFieldInfoPtr_Renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "Renderers");
			ScheduledMaterialChange.NativeFieldInfoPtr_MaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "MaterialIndex");
			ScheduledMaterialChange.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "Enabled");
			ScheduledMaterialChange.NativeFieldInfoPtr_OutsideTimeRangeMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "OutsideTimeRangeMaterial");
			ScheduledMaterialChange.NativeFieldInfoPtr_InsideTimeRangeMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "InsideTimeRangeMaterial");
			ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "TimeRangeMin");
			ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "TimeRangeMax");
			ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "TimeRangeShift");
			ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeRandomization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "TimeRangeRandomization");
			ScheduledMaterialChange.NativeFieldInfoPtr_TurnOnChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "TurnOnChance");
			ScheduledMaterialChange.NativeFieldInfoPtr_appliedInsideTimeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "appliedInsideTimeRange");
			ScheduledMaterialChange.NativeFieldInfoPtr_onState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "onState");
			ScheduledMaterialChange.NativeFieldInfoPtr_randomShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, "randomShift");
			ScheduledMaterialChange.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, 100686359);
			ScheduledMaterialChange.NativeMethodInfoPtr_Tick_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, 100686360);
			ScheduledMaterialChange.NativeMethodInfoPtr_SetMaterial_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, 100686361);
			ScheduledMaterialChange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr, 100686362);
		}

		// Token: 0x0600BA50 RID: 47696 RVA: 0x002E70AC File Offset: 0x002E52AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317296, XrefRangeEnd = 317314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScheduledMaterialChange.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA51 RID: 47697 RVA: 0x002E70E8 File Offset: 0x002E52E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317314, XrefRangeEnd = 317329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Tick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScheduledMaterialChange.NativeMethodInfoPtr_Tick_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA52 RID: 47698 RVA: 0x002E7124 File Offset: 0x002E5324
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317335, RefRangeEnd = 317338, XrefRangeStart = 317329, XrefRangeEnd = 317335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterial(bool insideTimeRange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref insideTimeRange;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledMaterialChange.NativeMethodInfoPtr_SetMaterial_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA53 RID: 47699 RVA: 0x002E7164 File Offset: 0x002E5364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317338, XrefRangeEnd = 317339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScheduledMaterialChange() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScheduledMaterialChange>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledMaterialChange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA54 RID: 47700 RVA: 0x0005B168 File Offset: 0x00059368
		public ScheduledMaterialChange(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003979 RID: 14713
		// (get) Token: 0x0600BA55 RID: 47701 RVA: 0x002E71A0 File Offset: 0x002E53A0
		// (set) Token: 0x0600BA56 RID: 47702 RVA: 0x0005B171 File Offset: 0x00059371
		public unsafe Il2CppReferenceArray<MeshRenderer> Renderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_Renderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_Renderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700397A RID: 14714
		// (get) Token: 0x0600BA57 RID: 47703 RVA: 0x002E71D0 File Offset: 0x002E53D0
		// (set) Token: 0x0600BA58 RID: 47704 RVA: 0x0005B190 File Offset: 0x00059390
		public unsafe int MaterialIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_MaterialIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_MaterialIndex)) = value;
			}
		}

		// Token: 0x1700397B RID: 14715
		// (get) Token: 0x0600BA59 RID: 47705 RVA: 0x002E71F8 File Offset: 0x002E53F8
		// (set) Token: 0x0600BA5A RID: 47706 RVA: 0x0005B1AB File Offset: 0x000593AB
		public unsafe bool Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_Enabled)) = value;
			}
		}

		// Token: 0x1700397C RID: 14716
		// (get) Token: 0x0600BA5B RID: 47707 RVA: 0x002E7220 File Offset: 0x002E5420
		// (set) Token: 0x0600BA5C RID: 47708 RVA: 0x0005B1C6 File Offset: 0x000593C6
		public unsafe Material OutsideTimeRangeMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_OutsideTimeRangeMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_OutsideTimeRangeMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700397D RID: 14717
		// (get) Token: 0x0600BA5D RID: 47709 RVA: 0x002E7250 File Offset: 0x002E5450
		// (set) Token: 0x0600BA5E RID: 47710 RVA: 0x0005B1E5 File Offset: 0x000593E5
		public unsafe Material InsideTimeRangeMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_InsideTimeRangeMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_InsideTimeRangeMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700397E RID: 14718
		// (get) Token: 0x0600BA5F RID: 47711 RVA: 0x002E7280 File Offset: 0x002E5480
		// (set) Token: 0x0600BA60 RID: 47712 RVA: 0x0005B204 File Offset: 0x00059404
		public unsafe int TimeRangeMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMin)) = value;
			}
		}

		// Token: 0x1700397F RID: 14719
		// (get) Token: 0x0600BA61 RID: 47713 RVA: 0x002E72A8 File Offset: 0x002E54A8
		// (set) Token: 0x0600BA62 RID: 47714 RVA: 0x0005B21F File Offset: 0x0005941F
		public unsafe int TimeRangeMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeMax)) = value;
			}
		}

		// Token: 0x17003980 RID: 14720
		// (get) Token: 0x0600BA63 RID: 47715 RVA: 0x002E72D0 File Offset: 0x002E54D0
		// (set) Token: 0x0600BA64 RID: 47716 RVA: 0x0005B23A File Offset: 0x0005943A
		public unsafe int TimeRangeShift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeShift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeShift)) = value;
			}
		}

		// Token: 0x17003981 RID: 14721
		// (get) Token: 0x0600BA65 RID: 47717 RVA: 0x002E72F8 File Offset: 0x002E54F8
		// (set) Token: 0x0600BA66 RID: 47718 RVA: 0x0005B255 File Offset: 0x00059455
		public unsafe int TimeRangeRandomization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeRandomization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TimeRangeRandomization)) = value;
			}
		}

		// Token: 0x17003982 RID: 14722
		// (get) Token: 0x0600BA67 RID: 47719 RVA: 0x002E7320 File Offset: 0x002E5520
		// (set) Token: 0x0600BA68 RID: 47720 RVA: 0x0005B270 File Offset: 0x00059470
		public unsafe float TurnOnChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TurnOnChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_TurnOnChance)) = value;
			}
		}

		// Token: 0x17003983 RID: 14723
		// (get) Token: 0x0600BA69 RID: 47721 RVA: 0x002E7348 File Offset: 0x002E5548
		// (set) Token: 0x0600BA6A RID: 47722 RVA: 0x0005B28B File Offset: 0x0005948B
		public unsafe bool appliedInsideTimeRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_appliedInsideTimeRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_appliedInsideTimeRange)) = value;
			}
		}

		// Token: 0x17003984 RID: 14724
		// (get) Token: 0x0600BA6B RID: 47723 RVA: 0x002E7370 File Offset: 0x002E5570
		// (set) Token: 0x0600BA6C RID: 47724 RVA: 0x0005B2A6 File Offset: 0x000594A6
		public unsafe ScheduledMaterialChange.EOnState onState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_onState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_onState)) = value;
			}
		}

		// Token: 0x17003985 RID: 14725
		// (get) Token: 0x0600BA6D RID: 47725 RVA: 0x002E7398 File Offset: 0x002E5598
		// (set) Token: 0x0600BA6E RID: 47726 RVA: 0x0005B2C1 File Offset: 0x000594C1
		public unsafe int randomShift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_randomShift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledMaterialChange.NativeFieldInfoPtr_randomShift)) = value;
			}
		}

		// Token: 0x04007DA8 RID: 32168
		private static readonly IntPtr NativeFieldInfoPtr_Renderers;

		// Token: 0x04007DA9 RID: 32169
		private static readonly IntPtr NativeFieldInfoPtr_MaterialIndex;

		// Token: 0x04007DAA RID: 32170
		private static readonly IntPtr NativeFieldInfoPtr_Enabled;

		// Token: 0x04007DAB RID: 32171
		private static readonly IntPtr NativeFieldInfoPtr_OutsideTimeRangeMaterial;

		// Token: 0x04007DAC RID: 32172
		private static readonly IntPtr NativeFieldInfoPtr_InsideTimeRangeMaterial;

		// Token: 0x04007DAD RID: 32173
		private static readonly IntPtr NativeFieldInfoPtr_TimeRangeMin;

		// Token: 0x04007DAE RID: 32174
		private static readonly IntPtr NativeFieldInfoPtr_TimeRangeMax;

		// Token: 0x04007DAF RID: 32175
		private static readonly IntPtr NativeFieldInfoPtr_TimeRangeShift;

		// Token: 0x04007DB0 RID: 32176
		private static readonly IntPtr NativeFieldInfoPtr_TimeRangeRandomization;

		// Token: 0x04007DB1 RID: 32177
		private static readonly IntPtr NativeFieldInfoPtr_TurnOnChance;

		// Token: 0x04007DB2 RID: 32178
		private static readonly IntPtr NativeFieldInfoPtr_appliedInsideTimeRange;

		// Token: 0x04007DB3 RID: 32179
		private static readonly IntPtr NativeFieldInfoPtr_onState;

		// Token: 0x04007DB4 RID: 32180
		private static readonly IntPtr NativeFieldInfoPtr_randomShift;

		// Token: 0x04007DB5 RID: 32181
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04007DB6 RID: 32182
		private static readonly IntPtr NativeMethodInfoPtr_Tick_Protected_Virtual_New_Void_0;

		// Token: 0x04007DB7 RID: 32183
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterial_Private_Void_Boolean_0;

		// Token: 0x04007DB8 RID: 32184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C61 RID: 3169
		[OriginalName("Assembly-CSharp.dll", "", "EOnState")]
		public enum EOnState
		{
			// Token: 0x040099EE RID: 39406
			Undecided,
			// Token: 0x040099EF RID: 39407
			On,
			// Token: 0x040099F0 RID: 39408
			Off
		}
	}
}
