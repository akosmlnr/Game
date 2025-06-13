using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000671 RID: 1649
	public class NotificationsManager : Singleton<NotificationsManager>
	{
		// Token: 0x06009167 RID: 37223 RVA: 0x0025E26C File Offset: 0x0025C46C
		// Note: this type is marked as 'beforefieldinit'.
		static NotificationsManager()
		{
			Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "NotificationsManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr);
			NotificationsManager.NativeFieldInfoPtr_MAX_NOTIFICATIONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, "MAX_NOTIFICATIONS");
			NotificationsManager.NativeFieldInfoPtr_EntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, "EntryContainer");
			NotificationsManager.NativeFieldInfoPtr_Sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, "Sound");
			NotificationsManager.NativeFieldInfoPtr_NotificationPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, "NotificationPrefab");
			NotificationsManager.NativeFieldInfoPtr_coroutines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, "coroutines");
			NotificationsManager.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, "entries");
			NotificationsManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, 100681429);
			NotificationsManager.NativeMethodInfoPtr_SendNotification_Public_Void_String_String_Sprite_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, 100681430);
			NotificationsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, 100681431);
		}

		// Token: 0x06009168 RID: 37224 RVA: 0x0025E350 File Offset: 0x0025C550
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009169 RID: 37225 RVA: 0x0025E384 File Offset: 0x0025C584
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 263916, RefRangeEnd = 263923, XrefRangeStart = 263840, XrefRangeEnd = 263916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendNotification(string title, string subtitle, Sprite icon, float duration = 5f, bool playSound = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subtitle);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(icon);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref duration;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref playSound;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.NativeMethodInfoPtr_SendNotification_Public_Void_String_String_Sprite_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600916A RID: 37226 RVA: 0x0025E408 File Offset: 0x0025C608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263923, XrefRangeEnd = 263940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotificationsManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600916B RID: 37227 RVA: 0x00045C9F File Offset: 0x00043E9F
		public NotificationsManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C40 RID: 11328
		// (get) Token: 0x0600916C RID: 37228 RVA: 0x0025E444 File Offset: 0x0025C644
		// (set) Token: 0x0600916D RID: 37229 RVA: 0x00045CA8 File Offset: 0x00043EA8
		public unsafe static int MAX_NOTIFICATIONS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NotificationsManager.NativeFieldInfoPtr_MAX_NOTIFICATIONS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotificationsManager.NativeFieldInfoPtr_MAX_NOTIFICATIONS, (void*)(&value));
			}
		}

		// Token: 0x17002C41 RID: 11329
		// (get) Token: 0x0600916E RID: 37230 RVA: 0x0025E460 File Offset: 0x0025C660
		// (set) Token: 0x0600916F RID: 37231 RVA: 0x00045CB6 File Offset: 0x00043EB6
		public unsafe RectTransform EntryContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_EntryContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_EntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C42 RID: 11330
		// (get) Token: 0x06009170 RID: 37232 RVA: 0x0025E490 File Offset: 0x0025C690
		// (set) Token: 0x06009171 RID: 37233 RVA: 0x00045CD5 File Offset: 0x00043ED5
		public unsafe AudioSourceController Sound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_Sound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_Sound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C43 RID: 11331
		// (get) Token: 0x06009172 RID: 37234 RVA: 0x0025E4C0 File Offset: 0x0025C6C0
		// (set) Token: 0x06009173 RID: 37235 RVA: 0x00045CF4 File Offset: 0x00043EF4
		public unsafe GameObject NotificationPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_NotificationPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_NotificationPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C44 RID: 11332
		// (get) Token: 0x06009174 RID: 37236 RVA: 0x0025E4F0 File Offset: 0x0025C6F0
		// (set) Token: 0x06009175 RID: 37237 RVA: 0x00045D13 File Offset: 0x00043F13
		public unsafe Dictionary<RectTransform, Coroutine> coroutines
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_coroutines);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<RectTransform, Coroutine>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_coroutines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C45 RID: 11333
		// (get) Token: 0x06009176 RID: 37238 RVA: 0x0025E520 File Offset: 0x0025C720
		// (set) Token: 0x06009177 RID: 37239 RVA: 0x00045D32 File Offset: 0x00043F32
		public unsafe List<RectTransform> entries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_entries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400626B RID: 25195
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_NOTIFICATIONS;

		// Token: 0x0400626C RID: 25196
		private static readonly System.IntPtr NativeFieldInfoPtr_EntryContainer;

		// Token: 0x0400626D RID: 25197
		private static readonly System.IntPtr NativeFieldInfoPtr_Sound;

		// Token: 0x0400626E RID: 25198
		private static readonly System.IntPtr NativeFieldInfoPtr_NotificationPrefab;

		// Token: 0x0400626F RID: 25199
		private static readonly System.IntPtr NativeFieldInfoPtr_coroutines;

		// Token: 0x04006270 RID: 25200
		private static readonly System.IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x04006271 RID: 25201
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006272 RID: 25202
		private static readonly System.IntPtr NativeMethodInfoPtr_SendNotification_Public_Void_String_String_Sprite_Single_Boolean_0;

		// Token: 0x04006273 RID: 25203
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B80 RID: 2944
		[ObfuscatedName("ScheduleOne.UI.NotificationsManager+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD3F RID: 56639 RVA: 0x0034B410 File Offset: 0x00349610
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr);
				NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr, "container");
				NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_startX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr, "startX");
				NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_endX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr, "endX");
				NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr, "lerpTime");
				NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr, "duration");
				NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_newEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr, "newEntry");
				NotificationsManager.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr, 100681432);
				NotificationsManager.__c__DisplayClass7_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr, 100681433);
			}

			// Token: 0x0600DD40 RID: 56640 RVA: 0x0034B4F0 File Offset: 0x003496F0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DD41 RID: 56641 RVA: 0x0034B52C File Offset: 0x0034972C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263835, XrefRangeEnd = 263840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass7_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DD42 RID: 56642 RVA: 0x0006B681 File Offset: 0x00069881
			public __c__DisplayClass7_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004445 RID: 17477
			// (get) Token: 0x0600DD43 RID: 56643 RVA: 0x0034B56C File Offset: 0x0034976C
			// (set) Token: 0x0600DD44 RID: 56644 RVA: 0x0006B68A File Offset: 0x0006988A
			public unsafe RectTransform container
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_container);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004446 RID: 17478
			// (get) Token: 0x0600DD45 RID: 56645 RVA: 0x0034B59C File Offset: 0x0034979C
			// (set) Token: 0x0600DD46 RID: 56646 RVA: 0x0006B6A9 File Offset: 0x000698A9
			public unsafe float startX
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_startX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_startX)) = value;
				}
			}

			// Token: 0x17004447 RID: 17479
			// (get) Token: 0x0600DD47 RID: 56647 RVA: 0x0034B5C4 File Offset: 0x003497C4
			// (set) Token: 0x0600DD48 RID: 56648 RVA: 0x0006B6C4 File Offset: 0x000698C4
			public unsafe float endX
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_endX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_endX)) = value;
				}
			}

			// Token: 0x17004448 RID: 17480
			// (get) Token: 0x0600DD49 RID: 56649 RVA: 0x0034B5EC File Offset: 0x003497EC
			// (set) Token: 0x0600DD4A RID: 56650 RVA: 0x0006B6DF File Offset: 0x000698DF
			public unsafe float lerpTime
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x17004449 RID: 17481
			// (get) Token: 0x0600DD4B RID: 56651 RVA: 0x0034B614 File Offset: 0x00349814
			// (set) Token: 0x0600DD4C RID: 56652 RVA: 0x0006B6FA File Offset: 0x000698FA
			public unsafe float duration
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x1700444A RID: 17482
			// (get) Token: 0x0600DD4D RID: 56653 RVA: 0x0034B63C File Offset: 0x0034983C
			// (set) Token: 0x0600DD4E RID: 56654 RVA: 0x0006B715 File Offset: 0x00069915
			public unsafe NotificationsManager __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NotificationsManager>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700444B RID: 17483
			// (get) Token: 0x0600DD4F RID: 56655 RVA: 0x0034B66C File Offset: 0x0034986C
			// (set) Token: 0x0600DD50 RID: 56656 RVA: 0x0006B734 File Offset: 0x00069934
			public unsafe RectTransform newEntry
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_newEntry);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.NativeFieldInfoPtr_newEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040094BC RID: 38076
			private static readonly System.IntPtr NativeFieldInfoPtr_container;

			// Token: 0x040094BD RID: 38077
			private static readonly System.IntPtr NativeFieldInfoPtr_startX;

			// Token: 0x040094BE RID: 38078
			private static readonly System.IntPtr NativeFieldInfoPtr_endX;

			// Token: 0x040094BF RID: 38079
			private static readonly System.IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x040094C0 RID: 38080
			private static readonly System.IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x040094C1 RID: 38081
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040094C2 RID: 38082
			private static readonly System.IntPtr NativeFieldInfoPtr_newEntry;

			// Token: 0x040094C3 RID: 38083
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040094C4 RID: 38084
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CD2 RID: 3282
			[ObfuscatedName("ScheduleOne.UI.NotificationsManager+<>c__DisplayClass7_0+<<SendNotification>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EB3D RID: 60221 RVA: 0x0037395C File Offset: 0x00371B5C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0>.NativeClassPtr, "<<SendNotification>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<i>5__2");
					NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100681434);
					NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100681435);
					NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100681436);
					NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100681437);
					NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100681438);
					NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100681439);
				}

				// Token: 0x0600EB3E RID: 60222 RVA: 0x00373A50 File Offset: 0x00371C50
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EB3F RID: 60223 RVA: 0x00373A98 File Offset: 0x00371C98
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EB40 RID: 60224 RVA: 0x00373ACC File Offset: 0x00371CCC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263816, XrefRangeEnd = 263830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170048D9 RID: 18649
				// (get) Token: 0x0600EB41 RID: 60225 RVA: 0x00373B08 File Offset: 0x00371D08
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EB42 RID: 60226 RVA: 0x00373B48 File Offset: 0x00371D48
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263830, XrefRangeEnd = 263835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170048DA RID: 18650
				// (get) Token: 0x0600EB43 RID: 60227 RVA: 0x00373B7C File Offset: 0x00371D7C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EB44 RID: 60228 RVA: 0x000726F8 File Offset: 0x000708F8
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170048D5 RID: 18645
				// (get) Token: 0x0600EB45 RID: 60229 RVA: 0x00373BBC File Offset: 0x00371DBC
				// (set) Token: 0x0600EB46 RID: 60230 RVA: 0x00072701 File Offset: 0x00070901
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170048D6 RID: 18646
				// (get) Token: 0x0600EB47 RID: 60231 RVA: 0x00373BE4 File Offset: 0x00371DE4
				// (set) Token: 0x0600EB48 RID: 60232 RVA: 0x0007271C File Offset: 0x0007091C
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170048D7 RID: 18647
				// (get) Token: 0x0600EB49 RID: 60233 RVA: 0x00373C14 File Offset: 0x00371E14
				// (set) Token: 0x0600EB4A RID: 60234 RVA: 0x0007273B File Offset: 0x0007093B
				public unsafe NotificationsManager.__c__DisplayClass7_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<NotificationsManager.__c__DisplayClass7_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170048D8 RID: 18648
				// (get) Token: 0x0600EB4B RID: 60235 RVA: 0x00373C44 File Offset: 0x00371E44
				// (set) Token: 0x0600EB4C RID: 60236 RVA: 0x0007275A File Offset: 0x0007095A
				public unsafe float _i_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass7_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x04009D54 RID: 40276
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009D55 RID: 40277
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009D56 RID: 40278
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009D57 RID: 40279
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x04009D58 RID: 40280
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009D59 RID: 40281
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D5A RID: 40282
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009D5B RID: 40283
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009D5C RID: 40284
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D5D RID: 40285
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
