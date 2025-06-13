using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.ObjectScripts.WateringCan;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005DF RID: 1503
	public class Equippable_WateringCan : Equippable_Pourable
	{
		// Token: 0x060082F3 RID: 33523 RVA: 0x002319E8 File Offset: 0x0022FBE8
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_WateringCan()
		{
			Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_WateringCan");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr);
			Equippable_WateringCan.NativeFieldInfoPtr__InteractionLabel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr, "<InteractionLabel>k__BackingField");
			Equippable_WateringCan.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr, "Visuals");
			Equippable_WateringCan.NativeFieldInfoPtr_WCInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr, "WCInstance");
			Equippable_WateringCan.NativeMethodInfoPtr_get_InteractionLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr, 100679813);
			Equippable_WateringCan.NativeMethodInfoPtr_set_InteractionLabel_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr, 100679814);
			Equippable_WateringCan.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr, 100679815);
			Equippable_WateringCan.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr, 100679816);
			Equippable_WateringCan.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr, 100679817);
			Equippable_WateringCan.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_Pot_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr, 100679818);
			Equippable_WateringCan.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr, 100679819);
			Equippable_WateringCan.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr, 100679820);
		}

		// Token: 0x17002761 RID: 10081
		// (get) Token: 0x060082F4 RID: 33524 RVA: 0x00231AF4 File Offset: 0x0022FCF4
		// (set) Token: 0x060082F5 RID: 33525 RVA: 0x00231B38 File Offset: 0x0022FD38
		public unsafe override string InteractionLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_WateringCan.NativeMethodInfoPtr_get_InteractionLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_WateringCan.NativeMethodInfoPtr_set_InteractionLabel_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060082F6 RID: 33526 RVA: 0x00231B88 File Offset: 0x0022FD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248431, XrefRangeEnd = 248451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_WateringCan.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060082F7 RID: 33527 RVA: 0x00231BD8 File Offset: 0x0022FDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248451, XrefRangeEnd = 248463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_WateringCan.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060082F8 RID: 33528 RVA: 0x00231C14 File Offset: 0x0022FE14
		[CallerCount(0)]
		public unsafe void UpdateVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_WateringCan.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060082F9 RID: 33529 RVA: 0x00231C48 File Offset: 0x0022FE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248463, XrefRangeEnd = 248473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanPour(Pot pot, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_WateringCan.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_Pot_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060082FA RID: 33530 RVA: 0x00231CBC File Offset: 0x0022FEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248473, XrefRangeEnd = 248477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartPourTask(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_WateringCan.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_Pot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060082FB RID: 33531 RVA: 0x00231D0C File Offset: 0x0022FF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248477, XrefRangeEnd = 248482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_WateringCan() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_WateringCan.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060082FC RID: 33532 RVA: 0x0003DE5D File Offset: 0x0003C05D
		public Equippable_WateringCan(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700275E RID: 10078
		// (get) Token: 0x060082FD RID: 33533 RVA: 0x00231D48 File Offset: 0x0022FF48
		// (set) Token: 0x060082FE RID: 33534 RVA: 0x0003DE66 File Offset: 0x0003C066
		public new unsafe string _InteractionLabel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_WateringCan.NativeFieldInfoPtr__InteractionLabel_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_WateringCan.NativeFieldInfoPtr__InteractionLabel_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700275F RID: 10079
		// (get) Token: 0x060082FF RID: 33535 RVA: 0x00231D70 File Offset: 0x0022FF70
		// (set) Token: 0x06008300 RID: 33536 RVA: 0x0003DE85 File Offset: 0x0003C085
		public unsafe WateringCanVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_WateringCan.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WateringCanVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_WateringCan.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002760 RID: 10080
		// (get) Token: 0x06008301 RID: 33537 RVA: 0x00231DA0 File Offset: 0x0022FFA0
		// (set) Token: 0x06008302 RID: 33538 RVA: 0x0003DEA4 File Offset: 0x0003C0A4
		public unsafe WateringCanInstance WCInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_WateringCan.NativeFieldInfoPtr_WCInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WateringCanInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_WateringCan.NativeFieldInfoPtr_WCInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005931 RID: 22833
		private static readonly IntPtr NativeFieldInfoPtr__InteractionLabel_k__BackingField;

		// Token: 0x04005932 RID: 22834
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04005933 RID: 22835
		private static readonly IntPtr NativeFieldInfoPtr_WCInstance;

		// Token: 0x04005934 RID: 22836
		private static readonly IntPtr NativeMethodInfoPtr_get_InteractionLabel_Public_Virtual_get_String_0;

		// Token: 0x04005935 RID: 22837
		private static readonly IntPtr NativeMethodInfoPtr_set_InteractionLabel_Public_Virtual_set_Void_String_0;

		// Token: 0x04005936 RID: 22838
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04005937 RID: 22839
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04005938 RID: 22840
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisuals_Private_Void_0;

		// Token: 0x04005939 RID: 22841
		private static readonly IntPtr NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_Pot_byref_String_0;

		// Token: 0x0400593A RID: 22842
		private static readonly IntPtr NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_Pot_0;

		// Token: 0x0400593B RID: 22843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
