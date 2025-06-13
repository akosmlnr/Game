using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000773 RID: 1907
	public class LabOvenButton : MonoBehaviour
	{
		// Token: 0x0600B278 RID: 45688 RVA: 0x002CAF08 File Offset: 0x002C9108
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenButton()
		{
			Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "LabOvenButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr);
			LabOvenButton.NativeFieldInfoPtr__Pressed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "<Pressed>k__BackingField");
			LabOvenButton.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "Button");
			LabOvenButton.NativeFieldInfoPtr_PressedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "PressedTransform");
			LabOvenButton.NativeFieldInfoPtr_DepressedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "DepressedTransform");
			LabOvenButton.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "Light");
			LabOvenButton.NativeFieldInfoPtr_Clickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "Clickable");
			LabOvenButton.NativeFieldInfoPtr_pressCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "pressCoroutine");
			LabOvenButton.NativeMethodInfoPtr_get_Pressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100685386);
			LabOvenButton.NativeMethodInfoPtr_set_Pressed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100685387);
			LabOvenButton.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100685388);
			LabOvenButton.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100685389);
			LabOvenButton.NativeMethodInfoPtr_Press_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100685390);
			LabOvenButton.NativeMethodInfoPtr_SetPressed_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100685391);
			LabOvenButton.NativeMethodInfoPtr_MoveButton_Private_IEnumerator_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100685392);
			LabOvenButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100685393);
		}

		// Token: 0x17003714 RID: 14100
		// (get) Token: 0x0600B279 RID: 45689 RVA: 0x002CB064 File Offset: 0x002C9264
		// (set) Token: 0x0600B27A RID: 45690 RVA: 0x002CB0A0 File Offset: 0x002C92A0
		public unsafe bool Pressed
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_get_Pressed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_set_Pressed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600B27B RID: 45691 RVA: 0x002CB0E0 File Offset: 0x002C92E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308307, XrefRangeEnd = 308317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B27C RID: 45692 RVA: 0x002CB114 File Offset: 0x002C9314
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 308317, RefRangeEnd = 308322, XrefRangeStart = 308317, XrefRangeEnd = 308317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool interactable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref interactable;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B27D RID: 45693 RVA: 0x002CB154 File Offset: 0x002C9354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308322, XrefRangeEnd = 308323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Press(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref hit;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_Press_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B27E RID: 45694 RVA: 0x002CB194 File Offset: 0x002C9394
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 308330, RefRangeEnd = 308334, XrefRangeStart = 308323, XrefRangeEnd = 308330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPressed(bool pressed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref pressed;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_SetPressed_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B27F RID: 45695 RVA: 0x002CB1D4 File Offset: 0x002C93D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308340, RefRangeEnd = 308341, XrefRangeStart = 308334, XrefRangeEnd = 308340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator MoveButton(Transform destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_MoveButton_Private_IEnumerator_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600B280 RID: 45696 RVA: 0x002CB224 File Offset: 0x002C9424
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenButton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B281 RID: 45697 RVA: 0x000575B9 File Offset: 0x000557B9
		public LabOvenButton(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700370D RID: 14093
		// (get) Token: 0x0600B282 RID: 45698 RVA: 0x002CB260 File Offset: 0x002C9460
		// (set) Token: 0x0600B283 RID: 45699 RVA: 0x000575C2 File Offset: 0x000557C2
		public unsafe bool _Pressed_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr__Pressed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr__Pressed_k__BackingField)) = value;
			}
		}

		// Token: 0x1700370E RID: 14094
		// (get) Token: 0x0600B284 RID: 45700 RVA: 0x002CB288 File Offset: 0x002C9488
		// (set) Token: 0x0600B285 RID: 45701 RVA: 0x000575DD File Offset: 0x000557DD
		public unsafe Transform Button
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Button);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700370F RID: 14095
		// (get) Token: 0x0600B286 RID: 45702 RVA: 0x002CB2B8 File Offset: 0x002C94B8
		// (set) Token: 0x0600B287 RID: 45703 RVA: 0x000575FC File Offset: 0x000557FC
		public unsafe Transform PressedTransform
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_PressedTransform);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_PressedTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003710 RID: 14096
		// (get) Token: 0x0600B288 RID: 45704 RVA: 0x002CB2E8 File Offset: 0x002C94E8
		// (set) Token: 0x0600B289 RID: 45705 RVA: 0x0005761B File Offset: 0x0005581B
		public unsafe Transform DepressedTransform
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_DepressedTransform);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_DepressedTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003711 RID: 14097
		// (get) Token: 0x0600B28A RID: 45706 RVA: 0x002CB318 File Offset: 0x002C9518
		// (set) Token: 0x0600B28B RID: 45707 RVA: 0x0005763A File Offset: 0x0005583A
		public unsafe ToggleableLight Light
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Light);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003712 RID: 14098
		// (get) Token: 0x0600B28C RID: 45708 RVA: 0x002CB348 File Offset: 0x002C9548
		// (set) Token: 0x0600B28D RID: 45709 RVA: 0x00057659 File Offset: 0x00055859
		public unsafe Clickable Clickable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Clickable);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Clickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003713 RID: 14099
		// (get) Token: 0x0600B28E RID: 45710 RVA: 0x002CB378 File Offset: 0x002C9578
		// (set) Token: 0x0600B28F RID: 45711 RVA: 0x00057678 File Offset: 0x00055878
		public unsafe Coroutine pressCoroutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_pressCoroutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_pressCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007840 RID: 30784
		private static readonly System.IntPtr NativeFieldInfoPtr__Pressed_k__BackingField;

		// Token: 0x04007841 RID: 30785
		private static readonly System.IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x04007842 RID: 30786
		private static readonly System.IntPtr NativeFieldInfoPtr_PressedTransform;

		// Token: 0x04007843 RID: 30787
		private static readonly System.IntPtr NativeFieldInfoPtr_DepressedTransform;

		// Token: 0x04007844 RID: 30788
		private static readonly System.IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x04007845 RID: 30789
		private static readonly System.IntPtr NativeFieldInfoPtr_Clickable;

		// Token: 0x04007846 RID: 30790
		private static readonly System.IntPtr NativeFieldInfoPtr_pressCoroutine;

		// Token: 0x04007847 RID: 30791
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Pressed_Public_get_Boolean_0;

		// Token: 0x04007848 RID: 30792
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Pressed_Private_set_Void_Boolean_0;

		// Token: 0x04007849 RID: 30793
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400784A RID: 30794
		private static readonly System.IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x0400784B RID: 30795
		private static readonly System.IntPtr NativeMethodInfoPtr_Press_Public_Void_RaycastHit_0;

		// Token: 0x0400784C RID: 30796
		private static readonly System.IntPtr NativeMethodInfoPtr_SetPressed_Public_Void_Boolean_0;

		// Token: 0x0400784D RID: 30797
		private static readonly System.IntPtr NativeMethodInfoPtr_MoveButton_Private_IEnumerator_Transform_0;

		// Token: 0x0400784E RID: 30798
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C4A RID: 3146
		[ObfuscatedName("ScheduleOne.ObjectScripts.LabOvenButton+<MoveButton>d__14")]
		public sealed class _MoveButton_d__14 : Il2CppSystem.Object
		{
			// Token: 0x0600E4EA RID: 58602 RVA: 0x00361208 File Offset: 0x0035F408
			// Note: this type is marked as 'beforefieldinit'.
			static _MoveButton_d__14()
			{
				Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "<MoveButton>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr);
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "<>1__state");
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "<>2__current");
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "<>4__this");
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "destination");
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__startPos_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "<startPos>5__2");
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__endPos_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "<endPos>5__3");
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__lerpTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "<lerpTime>5__4");
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__t_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "<t>5__5");
				LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, 100685394);
				LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, 100685395);
				LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, 100685396);
				LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, 100685397);
				LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, 100685398);
				LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, 100685399);
			}

			// Token: 0x0600E4EB RID: 58603 RVA: 0x0036134C File Offset: 0x0035F54C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MoveButton_d__14(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E4EC RID: 58604 RVA: 0x00361394 File Offset: 0x0035F594
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E4ED RID: 58605 RVA: 0x003613C8 File Offset: 0x0035F5C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308295, XrefRangeEnd = 308302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170046A6 RID: 18086
			// (get) Token: 0x0600E4EE RID: 58606 RVA: 0x00361404 File Offset: 0x0035F604
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E4EF RID: 58607 RVA: 0x00361444 File Offset: 0x0035F644
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308302, XrefRangeEnd = 308307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170046A7 RID: 18087
			// (get) Token: 0x0600E4F0 RID: 58608 RVA: 0x00361478 File Offset: 0x0035F678
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E4F1 RID: 58609 RVA: 0x0006F4B8 File Offset: 0x0006D6B8
			public _MoveButton_d__14(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700469E RID: 18078
			// (get) Token: 0x0600E4F2 RID: 58610 RVA: 0x003614B8 File Offset: 0x0035F6B8
			// (set) Token: 0x0600E4F3 RID: 58611 RVA: 0x0006F4C1 File Offset: 0x0006D6C1
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700469F RID: 18079
			// (get) Token: 0x0600E4F4 RID: 58612 RVA: 0x003614E0 File Offset: 0x0035F6E0
			// (set) Token: 0x0600E4F5 RID: 58613 RVA: 0x0006F4DC File Offset: 0x0006D6DC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046A0 RID: 18080
			// (get) Token: 0x0600E4F6 RID: 58614 RVA: 0x00361510 File Offset: 0x0035F710
			// (set) Token: 0x0600E4F7 RID: 58615 RVA: 0x0006F4FB File Offset: 0x0006D6FB
			public unsafe LabOvenButton __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOvenButton>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046A1 RID: 18081
			// (get) Token: 0x0600E4F8 RID: 58616 RVA: 0x00361540 File Offset: 0x0035F740
			// (set) Token: 0x0600E4F9 RID: 58617 RVA: 0x0006F51A File Offset: 0x0006D71A
			public unsafe Transform destination
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr_destination);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr_destination), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046A2 RID: 18082
			// (get) Token: 0x0600E4FA RID: 58618 RVA: 0x00361570 File Offset: 0x0035F770
			// (set) Token: 0x0600E4FB RID: 58619 RVA: 0x0006F539 File Offset: 0x0006D739
			public unsafe Vector3 _startPos_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__startPos_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__startPos_5__2)) = value;
				}
			}

			// Token: 0x170046A3 RID: 18083
			// (get) Token: 0x0600E4FC RID: 58620 RVA: 0x00361598 File Offset: 0x0035F798
			// (set) Token: 0x0600E4FD RID: 58621 RVA: 0x0006F554 File Offset: 0x0006D754
			public unsafe Vector3 _endPos_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__endPos_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__endPos_5__3)) = value;
				}
			}

			// Token: 0x170046A4 RID: 18084
			// (get) Token: 0x0600E4FE RID: 58622 RVA: 0x003615C0 File Offset: 0x0035F7C0
			// (set) Token: 0x0600E4FF RID: 58623 RVA: 0x0006F56F File Offset: 0x0006D76F
			public unsafe float _lerpTime_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__lerpTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__lerpTime_5__4)) = value;
				}
			}

			// Token: 0x170046A5 RID: 18085
			// (get) Token: 0x0600E500 RID: 58624 RVA: 0x003615E8 File Offset: 0x0035F7E8
			// (set) Token: 0x0600E501 RID: 58625 RVA: 0x0006F58A File Offset: 0x0006D78A
			public unsafe float _t_5__5
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__t_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__t_5__5)) = value;
				}
			}

			// Token: 0x0400995D RID: 39261
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400995E RID: 39262
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400995F RID: 39263
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009960 RID: 39264
			private static readonly System.IntPtr NativeFieldInfoPtr_destination;

			// Token: 0x04009961 RID: 39265
			private static readonly System.IntPtr NativeFieldInfoPtr__startPos_5__2;

			// Token: 0x04009962 RID: 39266
			private static readonly System.IntPtr NativeFieldInfoPtr__endPos_5__3;

			// Token: 0x04009963 RID: 39267
			private static readonly System.IntPtr NativeFieldInfoPtr__lerpTime_5__4;

			// Token: 0x04009964 RID: 39268
			private static readonly System.IntPtr NativeFieldInfoPtr__t_5__5;

			// Token: 0x04009965 RID: 39269
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009966 RID: 39270
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009967 RID: 39271
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009968 RID: 39272
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009969 RID: 39273
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400996A RID: 39274
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
