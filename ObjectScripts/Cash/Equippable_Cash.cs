using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.Cash
{
	// Token: 0x02000791 RID: 1937
	public class Equippable_Cash : Equippable_Viewmodel
	{
		// Token: 0x0600B7CA RID: 47050 RVA: 0x002DF734 File Offset: 0x002DD934
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Cash()
		{
			Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.Cash", "Equippable_Cash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr);
			Equippable_Cash.NativeFieldInfoPtr_amountIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "amountIndex");
			Equippable_Cash.NativeFieldInfoPtr_Container_Under100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "Container_Under100");
			Equippable_Cash.NativeFieldInfoPtr_SingleNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "SingleNotes");
			Equippable_Cash.NativeFieldInfoPtr_Container_100_300 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "Container_100_300");
			Equippable_Cash.NativeFieldInfoPtr_Under300Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "Under300Stacks");
			Equippable_Cash.NativeFieldInfoPtr_Container_300Plus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "Container_300Plus");
			Equippable_Cash.NativeFieldInfoPtr_PlusStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "PlusStacks");
			Equippable_Cash.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100686100);
			Equippable_Cash.NativeMethodInfoPtr_StartBuildingStoredItem_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100686101);
			Equippable_Cash.NativeMethodInfoPtr_StopBuildingStoredItem_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100686102);
			Equippable_Cash.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100686103);
			Equippable_Cash.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100686104);
			Equippable_Cash.NativeMethodInfoPtr_UpdateCashVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100686105);
			Equippable_Cash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100686106);
		}

		// Token: 0x0600B7CB RID: 47051 RVA: 0x002DF87C File Offset: 0x002DDA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314980, XrefRangeEnd = 314985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Cash.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7CC RID: 47052 RVA: 0x002DF8B8 File Offset: 0x002DDAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314985, XrefRangeEnd = 314991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartBuildingStoredItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Cash.NativeMethodInfoPtr_StartBuildingStoredItem_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7CD RID: 47053 RVA: 0x002DF8F4 File Offset: 0x002DDAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314991, XrefRangeEnd = 314997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopBuildingStoredItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Cash.NativeMethodInfoPtr_StopBuildingStoredItem_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7CE RID: 47054 RVA: 0x002DF930 File Offset: 0x002DDB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314997, XrefRangeEnd = 315013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Cash.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7CF RID: 47055 RVA: 0x002DF980 File Offset: 0x002DDB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315013, XrefRangeEnd = 315028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Cash.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7D0 RID: 47056 RVA: 0x002DF9BC File Offset: 0x002DDBBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315086, RefRangeEnd = 315087, XrefRangeStart = 315028, XrefRangeEnd = 315086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCashVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cash.NativeMethodInfoPtr_UpdateCashVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7D1 RID: 47057 RVA: 0x002DF9F0 File Offset: 0x002DDBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Cash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7D2 RID: 47058 RVA: 0x00059B50 File Offset: 0x00057D50
		public Equippable_Cash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038B0 RID: 14512
		// (get) Token: 0x0600B7D3 RID: 47059 RVA: 0x002DFA2C File Offset: 0x002DDC2C
		// (set) Token: 0x0600B7D4 RID: 47060 RVA: 0x00059B59 File Offset: 0x00057D59
		public unsafe int amountIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_amountIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_amountIndex)) = value;
			}
		}

		// Token: 0x170038B1 RID: 14513
		// (get) Token: 0x0600B7D5 RID: 47061 RVA: 0x002DFA54 File Offset: 0x002DDC54
		// (set) Token: 0x0600B7D6 RID: 47062 RVA: 0x00059B74 File Offset: 0x00057D74
		public unsafe Transform Container_Under100
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_Under100);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_Under100), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038B2 RID: 14514
		// (get) Token: 0x0600B7D7 RID: 47063 RVA: 0x002DFA84 File Offset: 0x002DDC84
		// (set) Token: 0x0600B7D8 RID: 47064 RVA: 0x00059B93 File Offset: 0x00057D93
		public unsafe List<Transform> SingleNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_SingleNotes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_SingleNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038B3 RID: 14515
		// (get) Token: 0x0600B7D9 RID: 47065 RVA: 0x002DFAB4 File Offset: 0x002DDCB4
		// (set) Token: 0x0600B7DA RID: 47066 RVA: 0x00059BB2 File Offset: 0x00057DB2
		public unsafe Transform Container_100_300
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_100_300);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_100_300), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038B4 RID: 14516
		// (get) Token: 0x0600B7DB RID: 47067 RVA: 0x002DFAE4 File Offset: 0x002DDCE4
		// (set) Token: 0x0600B7DC RID: 47068 RVA: 0x00059BD1 File Offset: 0x00057DD1
		public unsafe List<Transform> Under300Stacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Under300Stacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Under300Stacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038B5 RID: 14517
		// (get) Token: 0x0600B7DD RID: 47069 RVA: 0x002DFB14 File Offset: 0x002DDD14
		// (set) Token: 0x0600B7DE RID: 47070 RVA: 0x00059BF0 File Offset: 0x00057DF0
		public unsafe Transform Container_300Plus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_300Plus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_300Plus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038B6 RID: 14518
		// (get) Token: 0x0600B7DF RID: 47071 RVA: 0x002DFB44 File Offset: 0x002DDD44
		// (set) Token: 0x0600B7E0 RID: 47072 RVA: 0x00059C0F File Offset: 0x00057E0F
		public unsafe List<Transform> PlusStacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_PlusStacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_PlusStacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007C15 RID: 31765
		private static readonly IntPtr NativeFieldInfoPtr_amountIndex;

		// Token: 0x04007C16 RID: 31766
		private static readonly IntPtr NativeFieldInfoPtr_Container_Under100;

		// Token: 0x04007C17 RID: 31767
		private static readonly IntPtr NativeFieldInfoPtr_SingleNotes;

		// Token: 0x04007C18 RID: 31768
		private static readonly IntPtr NativeFieldInfoPtr_Container_100_300;

		// Token: 0x04007C19 RID: 31769
		private static readonly IntPtr NativeFieldInfoPtr_Under300Stacks;

		// Token: 0x04007C1A RID: 31770
		private static readonly IntPtr NativeFieldInfoPtr_Container_300Plus;

		// Token: 0x04007C1B RID: 31771
		private static readonly IntPtr NativeFieldInfoPtr_PlusStacks;

		// Token: 0x04007C1C RID: 31772
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04007C1D RID: 31773
		private static readonly IntPtr NativeMethodInfoPtr_StartBuildingStoredItem_Protected_Virtual_Void_0;

		// Token: 0x04007C1E RID: 31774
		private static readonly IntPtr NativeMethodInfoPtr_StopBuildingStoredItem_Protected_Virtual_Void_0;

		// Token: 0x04007C1F RID: 31775
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04007C20 RID: 31776
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04007C21 RID: 31777
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCashVisuals_Private_Void_0;

		// Token: 0x04007C22 RID: 31778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
