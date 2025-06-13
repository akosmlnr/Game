using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004F2 RID: 1266
	public class ButtonSound : MonoBehaviour
	{
		// Token: 0x06006DE6 RID: 28134 RVA: 0x001EA854 File Offset: 0x001E8A54
		// Note: this type is marked as 'beforefieldinit'.
		static ButtonSound()
		{
			Il2CppClassPointerStore<ButtonSound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "ButtonSound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr);
			ButtonSound.NativeFieldInfoPtr_AudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "AudioSource");
			ButtonSound.NativeFieldInfoPtr_EventTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "EventTrigger");
			ButtonSound.NativeFieldInfoPtr_PlaySoundOnClickStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "PlaySoundOnClickStart");
			ButtonSound.NativeFieldInfoPtr_HoverClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "HoverClip");
			ButtonSound.NativeFieldInfoPtr_HoverSoundVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "HoverSoundVolume");
			ButtonSound.NativeFieldInfoPtr_ClickClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "ClickClip");
			ButtonSound.NativeFieldInfoPtr_ClickSoundVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "ClickSoundVolume");
			ButtonSound.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "Button");
			ButtonSound.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, 100677279);
			ButtonSound.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, 100677280);
			ButtonSound.NativeMethodInfoPtr_AddEventTrigger_Public_Void_EventTrigger_EventTriggerType_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, 100677281);
			ButtonSound.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, 100677282);
			ButtonSound.NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, 100677283);
			ButtonSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, 100677284);
		}

		// Token: 0x06006DE7 RID: 28135 RVA: 0x001EA99C File Offset: 0x001E8B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220627, XrefRangeEnd = 220644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSound.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006DE8 RID: 28136 RVA: 0x001EA9D0 File Offset: 0x001E8BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220644, XrefRangeEnd = 220659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSound.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006DE9 RID: 28137 RVA: 0x001EAA04 File Offset: 0x001E8C04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 220681, RefRangeEnd = 220683, XrefRangeStart = 220659, XrefRangeEnd = 220681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddEventTrigger(EventTrigger eventTrigger, EventTriggerType eventTriggerType, Il2CppSystem.Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventTrigger);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref eventTriggerType;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSound.NativeMethodInfoPtr_AddEventTrigger_Public_Void_EventTrigger_EventTriggerType_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006DEA RID: 28138 RVA: 0x001EAA68 File Offset: 0x001E8C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220683, XrefRangeEnd = 220684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ButtonSound.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006DEB RID: 28139 RVA: 0x001EAAA4 File Offset: 0x001E8CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220684, XrefRangeEnd = 220685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ButtonSound.NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006DEC RID: 28140 RVA: 0x001EAAE0 File Offset: 0x001E8CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220685, XrefRangeEnd = 220686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonSound() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006DED RID: 28141 RVA: 0x00033C5C File Offset: 0x00031E5C
		public ButtonSound(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020D9 RID: 8409
		// (get) Token: 0x06006DEE RID: 28142 RVA: 0x001EAB1C File Offset: 0x001E8D1C
		// (set) Token: 0x06006DEF RID: 28143 RVA: 0x00033C65 File Offset: 0x00031E65
		public unsafe AudioSourceController AudioSource
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_AudioSource);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_AudioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020DA RID: 8410
		// (get) Token: 0x06006DF0 RID: 28144 RVA: 0x001EAB4C File Offset: 0x001E8D4C
		// (set) Token: 0x06006DF1 RID: 28145 RVA: 0x00033C84 File Offset: 0x00031E84
		public unsafe EventTrigger EventTrigger
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_EventTrigger);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventTrigger>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_EventTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020DB RID: 8411
		// (get) Token: 0x06006DF2 RID: 28146 RVA: 0x001EAB7C File Offset: 0x001E8D7C
		// (set) Token: 0x06006DF3 RID: 28147 RVA: 0x00033CA3 File Offset: 0x00031EA3
		public unsafe bool PlaySoundOnClickStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_PlaySoundOnClickStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_PlaySoundOnClickStart)) = value;
			}
		}

		// Token: 0x170020DC RID: 8412
		// (get) Token: 0x06006DF4 RID: 28148 RVA: 0x001EABA4 File Offset: 0x001E8DA4
		// (set) Token: 0x06006DF5 RID: 28149 RVA: 0x00033CBE File Offset: 0x00031EBE
		public unsafe AudioClip HoverClip
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_HoverClip);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_HoverClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020DD RID: 8413
		// (get) Token: 0x06006DF6 RID: 28150 RVA: 0x001EABD4 File Offset: 0x001E8DD4
		// (set) Token: 0x06006DF7 RID: 28151 RVA: 0x00033CDD File Offset: 0x00031EDD
		public unsafe float HoverSoundVolume
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_HoverSoundVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_HoverSoundVolume)) = value;
			}
		}

		// Token: 0x170020DE RID: 8414
		// (get) Token: 0x06006DF8 RID: 28152 RVA: 0x001EABFC File Offset: 0x001E8DFC
		// (set) Token: 0x06006DF9 RID: 28153 RVA: 0x00033CF8 File Offset: 0x00031EF8
		public unsafe AudioClip ClickClip
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_ClickClip);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_ClickClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020DF RID: 8415
		// (get) Token: 0x06006DFA RID: 28154 RVA: 0x001EAC2C File Offset: 0x001E8E2C
		// (set) Token: 0x06006DFB RID: 28155 RVA: 0x00033D17 File Offset: 0x00031F17
		public unsafe float ClickSoundVolume
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_ClickSoundVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_ClickSoundVolume)) = value;
			}
		}

		// Token: 0x170020E0 RID: 8416
		// (get) Token: 0x06006DFC RID: 28156 RVA: 0x001EAC54 File Offset: 0x001E8E54
		// (set) Token: 0x06006DFD RID: 28157 RVA: 0x00033D32 File Offset: 0x00031F32
		public unsafe Button Button
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_Button);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004B2F RID: 19247
		private static readonly System.IntPtr NativeFieldInfoPtr_AudioSource;

		// Token: 0x04004B30 RID: 19248
		private static readonly System.IntPtr NativeFieldInfoPtr_EventTrigger;

		// Token: 0x04004B31 RID: 19249
		private static readonly System.IntPtr NativeFieldInfoPtr_PlaySoundOnClickStart;

		// Token: 0x04004B32 RID: 19250
		private static readonly System.IntPtr NativeFieldInfoPtr_HoverClip;

		// Token: 0x04004B33 RID: 19251
		private static readonly System.IntPtr NativeFieldInfoPtr_HoverSoundVolume;

		// Token: 0x04004B34 RID: 19252
		private static readonly System.IntPtr NativeFieldInfoPtr_ClickClip;

		// Token: 0x04004B35 RID: 19253
		private static readonly System.IntPtr NativeFieldInfoPtr_ClickSoundVolume;

		// Token: 0x04004B36 RID: 19254
		private static readonly System.IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x04004B37 RID: 19255
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04004B38 RID: 19256
		private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04004B39 RID: 19257
		private static readonly System.IntPtr NativeMethodInfoPtr_AddEventTrigger_Public_Void_EventTrigger_EventTriggerType_Action_0;

		// Token: 0x04004B3A RID: 19258
		private static readonly System.IntPtr NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0;

		// Token: 0x04004B3B RID: 19259
		private static readonly System.IntPtr NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0;

		// Token: 0x04004B3C RID: 19260
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AA7 RID: 2727
		[ObfuscatedName("ScheduleOne.Audio.ButtonSound+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D5B3 RID: 54707 RVA: 0x00335ED0 File Offset: 0x003340D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<ButtonSound.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonSound.__c__DisplayClass10_0>.NativeClassPtr);
				ButtonSound.__c__DisplayClass10_0.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound.__c__DisplayClass10_0>.NativeClassPtr, "action");
				ButtonSound.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound.__c__DisplayClass10_0>.NativeClassPtr, 100677285);
				ButtonSound.__c__DisplayClass10_0.NativeMethodInfoPtr__AddEventTrigger_b__0_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound.__c__DisplayClass10_0>.NativeClassPtr, 100677286);
			}

			// Token: 0x0600D5B4 RID: 54708 RVA: 0x00335F38 File Offset: 0x00334138
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonSound.__c__DisplayClass10_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSound.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D5B5 RID: 54709 RVA: 0x00335F74 File Offset: 0x00334174
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddEventTrigger_b__0(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSound.__c__DisplayClass10_0.NativeMethodInfoPtr__AddEventTrigger_b__0_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D5B6 RID: 54710 RVA: 0x00067B77 File Offset: 0x00065D77
			public __c__DisplayClass10_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004212 RID: 16914
			// (get) Token: 0x0600D5B7 RID: 54711 RVA: 0x00335FB8 File Offset: 0x003341B8
			// (set) Token: 0x0600D5B8 RID: 54712 RVA: 0x00067B80 File Offset: 0x00065D80
			public unsafe Il2CppSystem.Action action
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.__c__DisplayClass10_0.NativeFieldInfoPtr_action);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.__c__DisplayClass10_0.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009046 RID: 36934
			private static readonly System.IntPtr NativeFieldInfoPtr_action;

			// Token: 0x04009047 RID: 36935
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009048 RID: 36936
			private static readonly System.IntPtr NativeMethodInfoPtr__AddEventTrigger_b__0_Internal_Void_BaseEventData_0;
		}
	}
}
