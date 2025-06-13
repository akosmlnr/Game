using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.PlayerTasks;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005E5 RID: 1509
	public class Equippable_Pourable : Equippable_Viewmodel
	{
		// Token: 0x0600836F RID: 33647 RVA: 0x002330D0 File Offset: 0x002312D0
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Pourable()
		{
			Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Pourable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr);
			Equippable_Pourable.NativeFieldInfoPtr__InteractionLabel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, "<InteractionLabel>k__BackingField");
			Equippable_Pourable.NativeFieldInfoPtr_InteractionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, "InteractionRange");
			Equippable_Pourable.NativeFieldInfoPtr_PourablePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, "PourablePrefab");
			Equippable_Pourable.NativeMethodInfoPtr_get_InteractionLabel_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679859);
			Equippable_Pourable.NativeMethodInfoPtr_set_InteractionLabel_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679860);
			Equippable_Pourable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679861);
			Equippable_Pourable.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_New_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679862);
			Equippable_Pourable.NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_Pot_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679863);
			Equippable_Pourable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679864);
		}

		// Token: 0x1700278A RID: 10122
		// (get) Token: 0x06008370 RID: 33648 RVA: 0x002331B4 File Offset: 0x002313B4
		// (set) Token: 0x06008371 RID: 33649 RVA: 0x002331F8 File Offset: 0x002313F8
		public unsafe virtual string InteractionLabel
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 24360, RefRangeEnd = 24376, XrefRangeStart = 24360, XrefRangeEnd = 24376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Pourable.NativeMethodInfoPtr_get_InteractionLabel_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Pourable.NativeMethodInfoPtr_set_InteractionLabel_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008372 RID: 33650 RVA: 0x00233248 File Offset: 0x00231448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248835, XrefRangeEnd = 248885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Pourable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008373 RID: 33651 RVA: 0x00233284 File Offset: 0x00231484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248885, XrefRangeEnd = 248889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartPourTask(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Pourable.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_New_Void_Pot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008374 RID: 33652 RVA: 0x002332D4 File Offset: 0x002314D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248889, XrefRangeEnd = 248892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanPour(Pot pot, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Pourable.NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_Pot_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008375 RID: 33653 RVA: 0x00233348 File Offset: 0x00231548
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 248899, RefRangeEnd = 248902, XrefRangeStart = 248892, XrefRangeEnd = 248899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Pourable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Pourable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008376 RID: 33654 RVA: 0x0003E2A6 File Offset: 0x0003C4A6
		public Equippable_Pourable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002787 RID: 10119
		// (get) Token: 0x06008377 RID: 33655 RVA: 0x00233384 File Offset: 0x00231584
		// (set) Token: 0x06008378 RID: 33656 RVA: 0x0003E2AF File Offset: 0x0003C4AF
		public unsafe string _InteractionLabel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Pourable.NativeFieldInfoPtr__InteractionLabel_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Pourable.NativeFieldInfoPtr__InteractionLabel_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002788 RID: 10120
		// (get) Token: 0x06008379 RID: 33657 RVA: 0x002333AC File Offset: 0x002315AC
		// (set) Token: 0x0600837A RID: 33658 RVA: 0x0003E2CE File Offset: 0x0003C4CE
		public unsafe float InteractionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Pourable.NativeFieldInfoPtr_InteractionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Pourable.NativeFieldInfoPtr_InteractionRange)) = value;
			}
		}

		// Token: 0x17002789 RID: 10121
		// (get) Token: 0x0600837B RID: 33659 RVA: 0x002333D4 File Offset: 0x002315D4
		// (set) Token: 0x0600837C RID: 33660 RVA: 0x0003E2E9 File Offset: 0x0003C4E9
		public unsafe Pourable PourablePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Pourable.NativeFieldInfoPtr_PourablePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pourable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Pourable.NativeFieldInfoPtr_PourablePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400597C RID: 22908
		private static readonly IntPtr NativeFieldInfoPtr__InteractionLabel_k__BackingField;

		// Token: 0x0400597D RID: 22909
		private static readonly IntPtr NativeFieldInfoPtr_InteractionRange;

		// Token: 0x0400597E RID: 22910
		private static readonly IntPtr NativeFieldInfoPtr_PourablePrefab;

		// Token: 0x0400597F RID: 22911
		private static readonly IntPtr NativeMethodInfoPtr_get_InteractionLabel_Public_Virtual_New_get_String_0;

		// Token: 0x04005980 RID: 22912
		private static readonly IntPtr NativeMethodInfoPtr_set_InteractionLabel_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04005981 RID: 22913
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04005982 RID: 22914
		private static readonly IntPtr NativeMethodInfoPtr_StartPourTask_Protected_Virtual_New_Void_Pot_0;

		// Token: 0x04005983 RID: 22915
		private static readonly IntPtr NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_Pot_byref_String_0;

		// Token: 0x04005984 RID: 22916
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
