using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005E2 RID: 1506
	public class Equippable_AvatarViewmodel : Equippable_Viewmodel
	{
		// Token: 0x06008316 RID: 33558 RVA: 0x002321D4 File Offset: 0x002303D4
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_AvatarViewmodel()
		{
			Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_AvatarViewmodel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr);
			Equippable_AvatarViewmodel.NativeFieldInfoPtr_AnimatorController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, "AnimatorController");
			Equippable_AvatarViewmodel.NativeFieldInfoPtr_ViewmodelAvatarOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, "ViewmodelAvatarOffset");
			Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, "EquipTime");
			Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, "EquipTrigger");
			Equippable_AvatarViewmodel.NativeFieldInfoPtr_timeEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, "timeEquipped");
			Equippable_AvatarViewmodel.NativeMethodInfoPtr_get_equipAnimDone_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679828);
			Equippable_AvatarViewmodel.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679829);
			Equippable_AvatarViewmodel.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679830);
			Equippable_AvatarViewmodel.NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679831);
			Equippable_AvatarViewmodel.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679832);
			Equippable_AvatarViewmodel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679833);
		}

		// Token: 0x1700276B RID: 10091
		// (get) Token: 0x06008317 RID: 33559 RVA: 0x002322E0 File Offset: 0x002304E0
		public unsafe bool equipAnimDone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_AvatarViewmodel.NativeMethodInfoPtr_get_equipAnimDone_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06008318 RID: 33560 RVA: 0x0023231C File Offset: 0x0023051C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 248556, RefRangeEnd = 248558, XrefRangeStart = 248532, XrefRangeEnd = 248556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_AvatarViewmodel.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008319 RID: 33561 RVA: 0x0023236C File Offset: 0x0023056C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 248565, RefRangeEnd = 248567, XrefRangeStart = 248558, XrefRangeEnd = 248565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_AvatarViewmodel.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600831A RID: 33562 RVA: 0x002323A8 File Offset: 0x002305A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248567, XrefRangeEnd = 248584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PlayEquipAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_AvatarViewmodel.NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600831B RID: 33563 RVA: 0x002323E4 File Offset: 0x002305E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248584, XrefRangeEnd = 248585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_AvatarViewmodel.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600831C RID: 33564 RVA: 0x00232420 File Offset: 0x00230620
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 248594, RefRangeEnd = 248597, XrefRangeStart = 248585, XrefRangeEnd = 248594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_AvatarViewmodel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_AvatarViewmodel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600831D RID: 33565 RVA: 0x0003DF49 File Offset: 0x0003C149
		public Equippable_AvatarViewmodel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002766 RID: 10086
		// (get) Token: 0x0600831E RID: 33566 RVA: 0x0023245C File Offset: 0x0023065C
		// (set) Token: 0x0600831F RID: 33567 RVA: 0x0003DF52 File Offset: 0x0003C152
		public unsafe RuntimeAnimatorController AnimatorController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_AnimatorController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_AnimatorController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002767 RID: 10087
		// (get) Token: 0x06008320 RID: 33568 RVA: 0x0023248C File Offset: 0x0023068C
		// (set) Token: 0x06008321 RID: 33569 RVA: 0x0003DF71 File Offset: 0x0003C171
		public unsafe Vector3 ViewmodelAvatarOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_ViewmodelAvatarOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_ViewmodelAvatarOffset)) = value;
			}
		}

		// Token: 0x17002768 RID: 10088
		// (get) Token: 0x06008322 RID: 33570 RVA: 0x002324B4 File Offset: 0x002306B4
		// (set) Token: 0x06008323 RID: 33571 RVA: 0x0003DF8C File Offset: 0x0003C18C
		public unsafe float EquipTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTime)) = value;
			}
		}

		// Token: 0x17002769 RID: 10089
		// (get) Token: 0x06008324 RID: 33572 RVA: 0x002324DC File Offset: 0x002306DC
		// (set) Token: 0x06008325 RID: 33573 RVA: 0x0003DFA7 File Offset: 0x0003C1A7
		public unsafe string EquipTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700276A RID: 10090
		// (get) Token: 0x06008326 RID: 33574 RVA: 0x00232504 File Offset: 0x00230704
		// (set) Token: 0x06008327 RID: 33575 RVA: 0x0003DFC6 File Offset: 0x0003C1C6
		public unsafe float timeEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_timeEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_timeEquipped)) = value;
			}
		}

		// Token: 0x04005947 RID: 22855
		private static readonly IntPtr NativeFieldInfoPtr_AnimatorController;

		// Token: 0x04005948 RID: 22856
		private static readonly IntPtr NativeFieldInfoPtr_ViewmodelAvatarOffset;

		// Token: 0x04005949 RID: 22857
		private static readonly IntPtr NativeFieldInfoPtr_EquipTime;

		// Token: 0x0400594A RID: 22858
		private static readonly IntPtr NativeFieldInfoPtr_EquipTrigger;

		// Token: 0x0400594B RID: 22859
		private static readonly IntPtr NativeFieldInfoPtr_timeEquipped;

		// Token: 0x0400594C RID: 22860
		private static readonly IntPtr NativeMethodInfoPtr_get_equipAnimDone_Protected_get_Boolean_0;

		// Token: 0x0400594D RID: 22861
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x0400594E RID: 22862
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x0400594F RID: 22863
		private static readonly IntPtr NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_Void_0;

		// Token: 0x04005950 RID: 22864
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04005951 RID: 22865
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
