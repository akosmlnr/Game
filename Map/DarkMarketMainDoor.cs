using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Doors;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.NPCs.CharacterClasses;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020007A1 RID: 1953
	public class DarkMarketMainDoor : MonoBehaviour
	{
		// Token: 0x0600B909 RID: 47369 RVA: 0x002E328C File Offset: 0x002E148C
		// Note: this type is marked as 'beforefieldinit'.
		static DarkMarketMainDoor()
		{
			Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "DarkMarketMainDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr);
			DarkMarketMainDoor.NativeFieldInfoPtr__KnockingEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "<KnockingEnabled>k__BackingField");
			DarkMarketMainDoor.NativeFieldInfoPtr_KnockSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "KnockSound");
			DarkMarketMainDoor.NativeFieldInfoPtr_InteractableObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "InteractableObject");
			DarkMarketMainDoor.NativeFieldInfoPtr_Peephole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "Peephole");
			DarkMarketMainDoor.NativeFieldInfoPtr_Igor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "Igor");
			DarkMarketMainDoor.NativeFieldInfoPtr_FailDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "FailDialogue");
			DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "SuccessDialogue");
			DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogueNotOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "SuccessDialogueNotOpen");
			DarkMarketMainDoor.NativeFieldInfoPtr_knockRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "knockRoutine");
			DarkMarketMainDoor.NativeMethodInfoPtr_get_KnockingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100686208);
			DarkMarketMainDoor.NativeMethodInfoPtr_set_KnockingEnabled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100686209);
			DarkMarketMainDoor.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100686210);
			DarkMarketMainDoor.NativeMethodInfoPtr_SetKnockingEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100686211);
			DarkMarketMainDoor.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100686212);
			DarkMarketMainDoor.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100686213);
			DarkMarketMainDoor.NativeMethodInfoPtr_Knocked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100686214);
			DarkMarketMainDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100686215);
			DarkMarketMainDoor.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100686216);
			DarkMarketMainDoor.NativeMethodInfoPtr__Knocked_b__16_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, 100686217);
		}

		// Token: 0x17003918 RID: 14616
		// (get) Token: 0x0600B90A RID: 47370 RVA: 0x002E3438 File Offset: 0x002E1638
		// (set) Token: 0x0600B90B RID: 47371 RVA: 0x002E3474 File Offset: 0x002E1674
		public unsafe bool KnockingEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_get_KnockingEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_set_KnockingEnabled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600B90C RID: 47372 RVA: 0x002E34B4 File Offset: 0x002E16B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257756, RefRangeEnd = 257757, XrefRangeStart = 257756, XrefRangeEnd = 257757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B90D RID: 47373 RVA: 0x002E34E8 File Offset: 0x002E16E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316145, XrefRangeEnd = 316147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetKnockingEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref enabled;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_SetKnockingEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B90E RID: 47374 RVA: 0x002E3528 File Offset: 0x002E1728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316147, XrefRangeEnd = 316155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B90F RID: 47375 RVA: 0x002E355C File Offset: 0x002E175C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316155, XrefRangeEnd = 316162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B910 RID: 47376 RVA: 0x002E3590 File Offset: 0x002E1790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Knocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_Knocked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B911 RID: 47377 RVA: 0x002E35C4 File Offset: 0x002E17C4
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 167373, RefRangeEnd = 167389, XrefRangeStart = 167373, XrefRangeEnd = 167389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DarkMarketMainDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B912 RID: 47378 RVA: 0x002E3600 File Offset: 0x002E1800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316162, XrefRangeEnd = 316167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600B913 RID: 47379 RVA: 0x002E3640 File Offset: 0x002E1840
		[CallerCount(0)]
		public unsafe bool _Knocked_b__16_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.NativeMethodInfoPtr__Knocked_b__16_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B914 RID: 47380 RVA: 0x0005A649 File Offset: 0x00058849
		public DarkMarketMainDoor(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700390F RID: 14607
		// (get) Token: 0x0600B915 RID: 47381 RVA: 0x002E367C File Offset: 0x002E187C
		// (set) Token: 0x0600B916 RID: 47382 RVA: 0x0005A652 File Offset: 0x00058852
		public unsafe bool _KnockingEnabled_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr__KnockingEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr__KnockingEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17003910 RID: 14608
		// (get) Token: 0x0600B917 RID: 47383 RVA: 0x002E36A4 File Offset: 0x002E18A4
		// (set) Token: 0x0600B918 RID: 47384 RVA: 0x0005A66D File Offset: 0x0005886D
		public unsafe AudioSource KnockSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_KnockSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_KnockSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003911 RID: 14609
		// (get) Token: 0x0600B919 RID: 47385 RVA: 0x002E36D4 File Offset: 0x002E18D4
		// (set) Token: 0x0600B91A RID: 47386 RVA: 0x0005A68C File Offset: 0x0005888C
		public unsafe InteractableObject InteractableObject
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_InteractableObject);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_InteractableObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003912 RID: 14610
		// (get) Token: 0x0600B91B RID: 47387 RVA: 0x002E3704 File Offset: 0x002E1904
		// (set) Token: 0x0600B91C RID: 47388 RVA: 0x0005A6AB File Offset: 0x000588AB
		public unsafe Peephole Peephole
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_Peephole);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Peephole>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_Peephole), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003913 RID: 14611
		// (get) Token: 0x0600B91D RID: 47389 RVA: 0x002E3734 File Offset: 0x002E1934
		// (set) Token: 0x0600B91E RID: 47390 RVA: 0x0005A6CA File Offset: 0x000588CA
		public unsafe Igor Igor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_Igor);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Igor>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_Igor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003914 RID: 14612
		// (get) Token: 0x0600B91F RID: 47391 RVA: 0x002E3764 File Offset: 0x002E1964
		// (set) Token: 0x0600B920 RID: 47392 RVA: 0x0005A6E9 File Offset: 0x000588E9
		public unsafe DialogueContainer FailDialogue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_FailDialogue);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_FailDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003915 RID: 14613
		// (get) Token: 0x0600B921 RID: 47393 RVA: 0x002E3794 File Offset: 0x002E1994
		// (set) Token: 0x0600B922 RID: 47394 RVA: 0x0005A708 File Offset: 0x00058908
		public unsafe DialogueContainer SuccessDialogue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogue);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003916 RID: 14614
		// (get) Token: 0x0600B923 RID: 47395 RVA: 0x002E37C4 File Offset: 0x002E19C4
		// (set) Token: 0x0600B924 RID: 47396 RVA: 0x0005A727 File Offset: 0x00058927
		public unsafe DialogueContainer SuccessDialogueNotOpen
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogueNotOpen);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_SuccessDialogueNotOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003917 RID: 14615
		// (get) Token: 0x0600B925 RID: 47397 RVA: 0x002E37F4 File Offset: 0x002E19F4
		// (set) Token: 0x0600B926 RID: 47398 RVA: 0x0005A746 File Offset: 0x00058946
		public unsafe Coroutine knockRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_knockRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.NativeFieldInfoPtr_knockRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007CD8 RID: 31960
		private static readonly System.IntPtr NativeFieldInfoPtr__KnockingEnabled_k__BackingField;

		// Token: 0x04007CD9 RID: 31961
		private static readonly System.IntPtr NativeFieldInfoPtr_KnockSound;

		// Token: 0x04007CDA RID: 31962
		private static readonly System.IntPtr NativeFieldInfoPtr_InteractableObject;

		// Token: 0x04007CDB RID: 31963
		private static readonly System.IntPtr NativeFieldInfoPtr_Peephole;

		// Token: 0x04007CDC RID: 31964
		private static readonly System.IntPtr NativeFieldInfoPtr_Igor;

		// Token: 0x04007CDD RID: 31965
		private static readonly System.IntPtr NativeFieldInfoPtr_FailDialogue;

		// Token: 0x04007CDE RID: 31966
		private static readonly System.IntPtr NativeFieldInfoPtr_SuccessDialogue;

		// Token: 0x04007CDF RID: 31967
		private static readonly System.IntPtr NativeFieldInfoPtr_SuccessDialogueNotOpen;

		// Token: 0x04007CE0 RID: 31968
		private static readonly System.IntPtr NativeFieldInfoPtr_knockRoutine;

		// Token: 0x04007CE1 RID: 31969
		private static readonly System.IntPtr NativeMethodInfoPtr_get_KnockingEnabled_Public_get_Boolean_0;

		// Token: 0x04007CE2 RID: 31970
		private static readonly System.IntPtr NativeMethodInfoPtr_set_KnockingEnabled_Private_set_Void_Boolean_0;

		// Token: 0x04007CE3 RID: 31971
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007CE4 RID: 31972
		private static readonly System.IntPtr NativeMethodInfoPtr_SetKnockingEnabled_Public_Void_Boolean_0;

		// Token: 0x04007CE5 RID: 31973
		private static readonly System.IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04007CE6 RID: 31974
		private static readonly System.IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04007CE7 RID: 31975
		private static readonly System.IntPtr NativeMethodInfoPtr_Knocked_Private_Void_0;

		// Token: 0x04007CE8 RID: 31976
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007CE9 RID: 31977
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04007CEA RID: 31978
		private static readonly System.IntPtr NativeMethodInfoPtr__Knocked_b__16_1_Private_Boolean_0;

		// Token: 0x02000C55 RID: 3157
		[ObfuscatedName("ScheduleOne.Map.DarkMarketMainDoor+<<Knocked>g__Knock|16_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600E55C RID: 58716 RVA: 0x003625E8 File Offset: 0x003607E8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique()
			{
				Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DarkMarketMainDoor>.NativeClassPtr, "<<Knocked>g__Knock|16_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, "<>1__state");
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, "<>2__current");
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, "<>4__this");
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr__shouldUnlock_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, "<shouldUnlock>5__2");
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100686218);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100686219);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100686220);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100686221);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100686222);
				DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr, 100686223);
			}

			// Token: 0x0600E55D RID: 58717 RVA: 0x003626DC File Offset: 0x003608DC
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E55E RID: 58718 RVA: 0x00362724 File Offset: 0x00360924
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E55F RID: 58719 RVA: 0x00362758 File Offset: 0x00360958
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316043, XrefRangeEnd = 316140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170046C6 RID: 18118
			// (get) Token: 0x0600E560 RID: 58720 RVA: 0x00362794 File Offset: 0x00360994
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E561 RID: 58721 RVA: 0x003627D4 File Offset: 0x003609D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316140, XrefRangeEnd = 316145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170046C7 RID: 18119
			// (get) Token: 0x0600E562 RID: 58722 RVA: 0x00362808 File Offset: 0x00360A08
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E563 RID: 58723 RVA: 0x0006F89E File Offset: 0x0006DA9E
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046C2 RID: 18114
			// (get) Token: 0x0600E564 RID: 58724 RVA: 0x00362848 File Offset: 0x00360A48
			// (set) Token: 0x0600E565 RID: 58725 RVA: 0x0006F8A7 File Offset: 0x0006DAA7
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170046C3 RID: 18115
			// (get) Token: 0x0600E566 RID: 58726 RVA: 0x00362870 File Offset: 0x00360A70
			// (set) Token: 0x0600E567 RID: 58727 RVA: 0x0006F8C2 File Offset: 0x0006DAC2
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046C4 RID: 18116
			// (get) Token: 0x0600E568 RID: 58728 RVA: 0x003628A0 File Offset: 0x00360AA0
			// (set) Token: 0x0600E569 RID: 58729 RVA: 0x0006F8E1 File Offset: 0x0006DAE1
			public unsafe DarkMarketMainDoor __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DarkMarketMainDoor>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046C5 RID: 18117
			// (get) Token: 0x0600E56A RID: 58730 RVA: 0x003628D0 File Offset: 0x00360AD0
			// (set) Token: 0x0600E56B RID: 58731 RVA: 0x0006F900 File Offset: 0x0006DB00
			public unsafe bool _shouldUnlock_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr__shouldUnlock_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarketMainDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaBoObObUnique.NativeFieldInfoPtr__shouldUnlock_5__2)) = value;
				}
			}

			// Token: 0x040099A7 RID: 39335
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040099A8 RID: 39336
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040099A9 RID: 39337
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040099AA RID: 39338
			private static readonly System.IntPtr NativeFieldInfoPtr__shouldUnlock_5__2;

			// Token: 0x040099AB RID: 39339
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040099AC RID: 39340
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040099AD RID: 39341
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040099AE RID: 39342
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040099AF RID: 39343
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040099B0 RID: 39344
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
