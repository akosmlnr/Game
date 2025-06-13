using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005E1 RID: 1505
	public class Equippable_Additive : Equippable_Pourable
	{
		// Token: 0x0600830E RID: 33550 RVA: 0x00231FC0 File Offset: 0x002301C0
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Additive()
		{
			Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Additive");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr);
			Equippable_Additive.NativeFieldInfoPtr_additiveDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr, "additiveDef");
			Equippable_Additive.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr, 100679824);
			Equippable_Additive.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr, 100679825);
			Equippable_Additive.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_Pot_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr, 100679826);
			Equippable_Additive.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr, 100679827);
		}

		// Token: 0x0600830F RID: 33551 RVA: 0x00232054 File Offset: 0x00230254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248501, XrefRangeEnd = 248512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Additive.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008310 RID: 33552 RVA: 0x002320A4 File Offset: 0x002302A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248512, XrefRangeEnd = 248516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartPourTask(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Additive.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_Pot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008311 RID: 33553 RVA: 0x002320F4 File Offset: 0x002302F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248516, XrefRangeEnd = 248531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanPour(Pot pot, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Additive.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_Pot_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008312 RID: 33554 RVA: 0x00232168 File Offset: 0x00230368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248531, XrefRangeEnd = 248532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Additive() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Additive.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008313 RID: 33555 RVA: 0x0003DF21 File Offset: 0x0003C121
		public Equippable_Additive(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002765 RID: 10085
		// (get) Token: 0x06008314 RID: 33556 RVA: 0x002321A4 File Offset: 0x002303A4
		// (set) Token: 0x06008315 RID: 33557 RVA: 0x0003DF2A File Offset: 0x0003C12A
		public unsafe AdditiveDefinition additiveDef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Additive.NativeFieldInfoPtr_additiveDef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdditiveDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Additive.NativeFieldInfoPtr_additiveDef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005942 RID: 22850
		private static readonly IntPtr NativeFieldInfoPtr_additiveDef;

		// Token: 0x04005943 RID: 22851
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04005944 RID: 22852
		private static readonly IntPtr NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_Pot_0;

		// Token: 0x04005945 RID: 22853
		private static readonly IntPtr NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_Pot_byref_String_0;

		// Token: 0x04005946 RID: 22854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
