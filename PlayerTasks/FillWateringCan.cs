using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts.WateringCan;
using Il2CppScheduleOne.Property.Utilities.Water;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000215 RID: 533
	public class FillWateringCan : Task
	{
		// Token: 0x06002BCB RID: 11211 RVA: 0x000FE120 File Offset: 0x000FC320
		// Note: this type is marked as 'beforefieldinit'.
		static FillWateringCan()
		{
			Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "FillWateringCan");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr);
			FillWateringCan.NativeFieldInfoPtr__TaskName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, "<TaskName>k__BackingField");
			FillWateringCan.NativeFieldInfoPtr_tap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, "tap");
			FillWateringCan.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, "instance");
			FillWateringCan.NativeFieldInfoPtr_visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, "visuals");
			FillWateringCan.NativeFieldInfoPtr_audioPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, "audioPlayed");
			FillWateringCan.NativeMethodInfoPtr_get_TaskName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, 100668248);
			FillWateringCan.NativeMethodInfoPtr_set_TaskName_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, 100668249);
			FillWateringCan.NativeMethodInfoPtr__ctor_Public_Void_Tap_WateringCanInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, 100668250);
			FillWateringCan.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, 100668251);
			FillWateringCan.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, 100668252);
			FillWateringCan.NativeMethodInfoPtr_HandleClickStart_Private_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, 100668253);
			FillWateringCan.NativeMethodInfoPtr_HandleClickEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr, 100668254);
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06002BCC RID: 11212 RVA: 0x000FE240 File Offset: 0x000FC440
		// (set) Token: 0x06002BCD RID: 11213 RVA: 0x000FE278 File Offset: 0x000FC478
		public new unsafe string TaskName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(FillWateringCan.NativeMethodInfoPtr_get_TaskName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FillWateringCan.NativeMethodInfoPtr_set_TaskName_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x000FE2BC File Offset: 0x000FC4BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125040, RefRangeEnd = 125041, XrefRangeStart = 124978, XrefRangeEnd = 125040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FillWateringCan(Tap _tap, WateringCanInstance _instance) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FillWateringCan>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_tap);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_instance);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FillWateringCan.NativeMethodInfoPtr__ctor_Public_Void_Tap_WateringCanInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x000FE31C File Offset: 0x000FC51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125041, XrefRangeEnd = 125055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FillWateringCan.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x000FE358 File Offset: 0x000FC558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125055, XrefRangeEnd = 125087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FillWateringCan.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002BD1 RID: 11217 RVA: 0x000FE394 File Offset: 0x000FC594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125087, XrefRangeEnd = 125089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FillWateringCan.NativeMethodInfoPtr_HandleClickStart_Private_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002BD2 RID: 11218 RVA: 0x000FE3D4 File Offset: 0x000FC5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125089, XrefRangeEnd = 125091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FillWateringCan.NativeMethodInfoPtr_HandleClickEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x000179C6 File Offset: 0x00015BC6
		public FillWateringCan(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x000FE408 File Offset: 0x000FC608
		// (set) Token: 0x06002BD5 RID: 11221 RVA: 0x000179CF File Offset: 0x00015BCF
		public new unsafe string _TaskName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWateringCan.NativeFieldInfoPtr__TaskName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWateringCan.NativeFieldInfoPtr__TaskName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06002BD6 RID: 11222 RVA: 0x000FE430 File Offset: 0x000FC630
		// (set) Token: 0x06002BD7 RID: 11223 RVA: 0x000179EE File Offset: 0x00015BEE
		public unsafe Tap tap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWateringCan.NativeFieldInfoPtr_tap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWateringCan.NativeFieldInfoPtr_tap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x000FE460 File Offset: 0x000FC660
		// (set) Token: 0x06002BD9 RID: 11225 RVA: 0x00017A0D File Offset: 0x00015C0D
		public unsafe WateringCanInstance instance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWateringCan.NativeFieldInfoPtr_instance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WateringCanInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWateringCan.NativeFieldInfoPtr_instance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06002BDA RID: 11226 RVA: 0x000FE490 File Offset: 0x000FC690
		// (set) Token: 0x06002BDB RID: 11227 RVA: 0x00017A2C File Offset: 0x00015C2C
		public unsafe WateringCanVisuals visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWateringCan.NativeFieldInfoPtr_visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WateringCanVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWateringCan.NativeFieldInfoPtr_visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06002BDC RID: 11228 RVA: 0x000FE4C0 File Offset: 0x000FC6C0
		// (set) Token: 0x06002BDD RID: 11229 RVA: 0x00017A4B File Offset: 0x00015C4B
		public unsafe bool audioPlayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWateringCan.NativeFieldInfoPtr_audioPlayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillWateringCan.NativeFieldInfoPtr_audioPlayed)) = value;
			}
		}

		// Token: 0x04001D0A RID: 7434
		private static readonly IntPtr NativeFieldInfoPtr__TaskName_k__BackingField;

		// Token: 0x04001D0B RID: 7435
		private static readonly IntPtr NativeFieldInfoPtr_tap;

		// Token: 0x04001D0C RID: 7436
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x04001D0D RID: 7437
		private static readonly IntPtr NativeFieldInfoPtr_visuals;

		// Token: 0x04001D0E RID: 7438
		private static readonly IntPtr NativeFieldInfoPtr_audioPlayed;

		// Token: 0x04001D0F RID: 7439
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskName_Public_get_String_0;

		// Token: 0x04001D10 RID: 7440
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskName_Protected_set_Void_String_0;

		// Token: 0x04001D11 RID: 7441
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Tap_WateringCanInstance_0;

		// Token: 0x04001D12 RID: 7442
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001D13 RID: 7443
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001D14 RID: 7444
		private static readonly IntPtr NativeMethodInfoPtr_HandleClickStart_Private_Void_RaycastHit_0;

		// Token: 0x04001D15 RID: 7445
		private static readonly IntPtr NativeMethodInfoPtr_HandleClickEnd_Private_Void_0;
	}
}
