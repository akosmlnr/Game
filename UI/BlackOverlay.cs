using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200064A RID: 1610
	public class BlackOverlay : Singleton<BlackOverlay>
	{
		// Token: 0x06008CE8 RID: 36072 RVA: 0x00250D8C File Offset: 0x0024EF8C
		// Note: this type is marked as 'beforefieldinit'.
		static BlackOverlay()
		{
			Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "BlackOverlay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr);
			BlackOverlay.NativeFieldInfoPtr__isShown_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, "<isShown>k__BackingField");
			BlackOverlay.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, "canvas");
			BlackOverlay.NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, "group");
			BlackOverlay.NativeFieldInfoPtr_fadeRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, "fadeRoutine");
			BlackOverlay.NativeMethodInfoPtr_get_isShown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100680900);
			BlackOverlay.NativeMethodInfoPtr_set_isShown_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100680901);
			BlackOverlay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100680902);
			BlackOverlay.NativeMethodInfoPtr_Open_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100680903);
			BlackOverlay.NativeMethodInfoPtr_Close_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100680904);
			BlackOverlay.NativeMethodInfoPtr_Fade_Private_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100680905);
			BlackOverlay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100680906);
		}

		// Token: 0x17002ABB RID: 10939
		// (get) Token: 0x06008CE9 RID: 36073 RVA: 0x00250E98 File Offset: 0x0024F098
		// (set) Token: 0x06008CEA RID: 36074 RVA: 0x00250ED4 File Offset: 0x0024F0D4
		public unsafe bool isShown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr_get_isShown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr_set_isShown_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008CEB RID: 36075 RVA: 0x00250F14 File Offset: 0x0024F114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258289, XrefRangeEnd = 258295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackOverlay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008CEC RID: 36076 RVA: 0x00250F50 File Offset: 0x0024F150
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 258301, RefRangeEnd = 258306, XrefRangeStart = 258295, XrefRangeEnd = 258301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(float fadeTime = 0.5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fadeTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr_Open_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008CED RID: 36077 RVA: 0x00250F90 File Offset: 0x0024F190
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 258310, RefRangeEnd = 258317, XrefRangeStart = 258306, XrefRangeEnd = 258310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(float fadeTime = 0.5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fadeTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr_Close_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008CEE RID: 36078 RVA: 0x00250FD0 File Offset: 0x0024F1D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 258322, RefRangeEnd = 258325, XrefRangeStart = 258317, XrefRangeEnd = 258322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Fade(float endOpacity, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref endOpacity;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref fadeTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr_Fade_Private_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06008CEF RID: 36079 RVA: 0x0025102C File Offset: 0x0024F22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258325, XrefRangeEnd = 258328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlackOverlay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008CF0 RID: 36080 RVA: 0x000431EB File Offset: 0x000413EB
		public BlackOverlay(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AB7 RID: 10935
		// (get) Token: 0x06008CF1 RID: 36081 RVA: 0x00251068 File Offset: 0x0024F268
		// (set) Token: 0x06008CF2 RID: 36082 RVA: 0x000431F4 File Offset: 0x000413F4
		public unsafe bool _isShown_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr__isShown_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr__isShown_k__BackingField)) = value;
			}
		}

		// Token: 0x17002AB8 RID: 10936
		// (get) Token: 0x06008CF3 RID: 36083 RVA: 0x00251090 File Offset: 0x0024F290
		// (set) Token: 0x06008CF4 RID: 36084 RVA: 0x0004320F File Offset: 0x0004140F
		public unsafe Canvas canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AB9 RID: 10937
		// (get) Token: 0x06008CF5 RID: 36085 RVA: 0x002510C0 File Offset: 0x0024F2C0
		// (set) Token: 0x06008CF6 RID: 36086 RVA: 0x0004322E File Offset: 0x0004142E
		public unsafe CanvasGroup group
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_group);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ABA RID: 10938
		// (get) Token: 0x06008CF7 RID: 36087 RVA: 0x002510F0 File Offset: 0x0024F2F0
		// (set) Token: 0x06008CF8 RID: 36088 RVA: 0x0004324D File Offset: 0x0004144D
		public unsafe Coroutine fadeRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_fadeRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_fadeRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005F9E RID: 24478
		private static readonly System.IntPtr NativeFieldInfoPtr__isShown_k__BackingField;

		// Token: 0x04005F9F RID: 24479
		private static readonly System.IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04005FA0 RID: 24480
		private static readonly System.IntPtr NativeFieldInfoPtr_group;

		// Token: 0x04005FA1 RID: 24481
		private static readonly System.IntPtr NativeFieldInfoPtr_fadeRoutine;

		// Token: 0x04005FA2 RID: 24482
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isShown_Public_get_Boolean_0;

		// Token: 0x04005FA3 RID: 24483
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isShown_Protected_set_Void_Boolean_0;

		// Token: 0x04005FA4 RID: 24484
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005FA5 RID: 24485
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_Single_0;

		// Token: 0x04005FA6 RID: 24486
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_Single_0;

		// Token: 0x04005FA7 RID: 24487
		private static readonly System.IntPtr NativeMethodInfoPtr_Fade_Private_IEnumerator_Single_Single_0;

		// Token: 0x04005FA8 RID: 24488
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B60 RID: 2912
		[ObfuscatedName("ScheduleOne.UI.BlackOverlay+<Fade>d__10")]
		public sealed class _Fade_d__10 : Il2CppSystem.Object
		{
			// Token: 0x0600DBC5 RID: 56261 RVA: 0x003471D4 File Offset: 0x003453D4
			// Note: this type is marked as 'beforefieldinit'.
			static _Fade_d__10()
			{
				Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, "<Fade>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr);
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "<>1__state");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "<>2__current");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "<>4__this");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr_endOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "endOpacity");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr_fadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "fadeTime");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr__start_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "<start>5__2");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "<i>5__3");
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100680907);
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100680908);
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100680909);
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100680910);
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100680911);
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100680912);
			}

			// Token: 0x0600DBC6 RID: 56262 RVA: 0x00347304 File Offset: 0x00345504
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Fade_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DBC7 RID: 56263 RVA: 0x0034734C File Offset: 0x0034554C
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DBC8 RID: 56264 RVA: 0x00347380 File Offset: 0x00345580
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258274, XrefRangeEnd = 258284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170043CD RID: 17357
			// (get) Token: 0x0600DBC9 RID: 56265 RVA: 0x003473BC File Offset: 0x003455BC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DBCA RID: 56266 RVA: 0x003473FC File Offset: 0x003455FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258284, XrefRangeEnd = 258289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170043CE RID: 17358
			// (get) Token: 0x0600DBCB RID: 56267 RVA: 0x00347430 File Offset: 0x00345630
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DBCC RID: 56268 RVA: 0x0006A9F7 File Offset: 0x00068BF7
			public _Fade_d__10(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043C6 RID: 17350
			// (get) Token: 0x0600DBCD RID: 56269 RVA: 0x00347470 File Offset: 0x00345670
			// (set) Token: 0x0600DBCE RID: 56270 RVA: 0x0006AA00 File Offset: 0x00068C00
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043C7 RID: 17351
			// (get) Token: 0x0600DBCF RID: 56271 RVA: 0x00347498 File Offset: 0x00345698
			// (set) Token: 0x0600DBD0 RID: 56272 RVA: 0x0006AA1B File Offset: 0x00068C1B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043C8 RID: 17352
			// (get) Token: 0x0600DBD1 RID: 56273 RVA: 0x003474C8 File Offset: 0x003456C8
			// (set) Token: 0x0600DBD2 RID: 56274 RVA: 0x0006AA3A File Offset: 0x00068C3A
			public unsafe BlackOverlay __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackOverlay>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043C9 RID: 17353
			// (get) Token: 0x0600DBD3 RID: 56275 RVA: 0x003474F8 File Offset: 0x003456F8
			// (set) Token: 0x0600DBD4 RID: 56276 RVA: 0x0006AA59 File Offset: 0x00068C59
			public unsafe float endOpacity
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr_endOpacity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr_endOpacity)) = value;
				}
			}

			// Token: 0x170043CA RID: 17354
			// (get) Token: 0x0600DBD5 RID: 56277 RVA: 0x00347520 File Offset: 0x00345720
			// (set) Token: 0x0600DBD6 RID: 56278 RVA: 0x0006AA74 File Offset: 0x00068C74
			public unsafe float fadeTime
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr_fadeTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr_fadeTime)) = value;
				}
			}

			// Token: 0x170043CB RID: 17355
			// (get) Token: 0x0600DBD7 RID: 56279 RVA: 0x00347548 File Offset: 0x00345748
			// (set) Token: 0x0600DBD8 RID: 56280 RVA: 0x0006AA8F File Offset: 0x00068C8F
			public unsafe float _start_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr__start_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr__start_5__2)) = value;
				}
			}

			// Token: 0x170043CC RID: 17356
			// (get) Token: 0x0600DBD9 RID: 56281 RVA: 0x00347570 File Offset: 0x00345770
			// (set) Token: 0x0600DBDA RID: 56282 RVA: 0x0006AAAA File Offset: 0x00068CAA
			public unsafe float _i_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040093E4 RID: 37860
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040093E5 RID: 37861
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040093E6 RID: 37862
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040093E7 RID: 37863
			private static readonly System.IntPtr NativeFieldInfoPtr_endOpacity;

			// Token: 0x040093E8 RID: 37864
			private static readonly System.IntPtr NativeFieldInfoPtr_fadeTime;

			// Token: 0x040093E9 RID: 37865
			private static readonly System.IntPtr NativeFieldInfoPtr__start_5__2;

			// Token: 0x040093EA RID: 37866
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040093EB RID: 37867
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040093EC RID: 37868
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040093ED RID: 37869
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040093EE RID: 37870
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040093EF RID: 37871
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040093F0 RID: 37872
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
