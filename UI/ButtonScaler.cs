using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200064C RID: 1612
	public class ButtonScaler : MonoBehaviour
	{
		// Token: 0x06008D43 RID: 36163 RVA: 0x00251D98 File Offset: 0x0024FF98
		// Note: this type is marked as 'beforefieldinit'.
		static ButtonScaler()
		{
			Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ButtonScaler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr);
			ButtonScaler.NativeFieldInfoPtr_ScaleTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, "ScaleTarget");
			ButtonScaler.NativeFieldInfoPtr_HoverScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, "HoverScale");
			ButtonScaler.NativeFieldInfoPtr_ScaleTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, "ScaleTime");
			ButtonScaler.NativeFieldInfoPtr_scaleCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, "scaleCoroutine");
			ButtonScaler.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, "button");
			ButtonScaler.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, 100680941);
			ButtonScaler.NativeMethodInfoPtr_Hovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, 100680942);
			ButtonScaler.NativeMethodInfoPtr_HoverEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, 100680943);
			ButtonScaler.NativeMethodInfoPtr_SetScale_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, 100680944);
			ButtonScaler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, 100680945);
			ButtonScaler.NativeMethodInfoPtr__Awake_b__5_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, 100680946);
			ButtonScaler.NativeMethodInfoPtr__Awake_b__5_1_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, 100680947);
		}

		// Token: 0x06008D44 RID: 36164 RVA: 0x00251EB8 File Offset: 0x002500B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258754, XrefRangeEnd = 258793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D45 RID: 36165 RVA: 0x00251EEC File Offset: 0x002500EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258793, XrefRangeEnd = 258794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.NativeMethodInfoPtr_Hovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D46 RID: 36166 RVA: 0x00251F20 File Offset: 0x00250120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258794, XrefRangeEnd = 258795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HoverEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.NativeMethodInfoPtr_HoverEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D47 RID: 36167 RVA: 0x00251F54 File Offset: 0x00250154
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 258809, RefRangeEnd = 258813, XrefRangeStart = 258795, XrefRangeEnd = 258809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScale(float endScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref endScale;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.NativeMethodInfoPtr_SetScale_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D48 RID: 36168 RVA: 0x00251F94 File Offset: 0x00250194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258813, XrefRangeEnd = 258814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonScaler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D49 RID: 36169 RVA: 0x00251FD0 File Offset: 0x002501D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__5_0(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.NativeMethodInfoPtr__Awake_b__5_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D4A RID: 36170 RVA: 0x00252014 File Offset: 0x00250214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__5_1(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.NativeMethodInfoPtr__Awake_b__5_1_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D4B RID: 36171 RVA: 0x000435A8 File Offset: 0x000417A8
		public ButtonScaler(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002ADA RID: 10970
		// (get) Token: 0x06008D4C RID: 36172 RVA: 0x00252058 File Offset: 0x00250258
		// (set) Token: 0x06008D4D RID: 36173 RVA: 0x000435B1 File Offset: 0x000417B1
		public unsafe RectTransform ScaleTarget
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.NativeFieldInfoPtr_ScaleTarget);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.NativeFieldInfoPtr_ScaleTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ADB RID: 10971
		// (get) Token: 0x06008D4E RID: 36174 RVA: 0x00252088 File Offset: 0x00250288
		// (set) Token: 0x06008D4F RID: 36175 RVA: 0x000435D0 File Offset: 0x000417D0
		public unsafe float HoverScale
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.NativeFieldInfoPtr_HoverScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.NativeFieldInfoPtr_HoverScale)) = value;
			}
		}

		// Token: 0x17002ADC RID: 10972
		// (get) Token: 0x06008D50 RID: 36176 RVA: 0x002520B0 File Offset: 0x002502B0
		// (set) Token: 0x06008D51 RID: 36177 RVA: 0x000435EB File Offset: 0x000417EB
		public unsafe float ScaleTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.NativeFieldInfoPtr_ScaleTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.NativeFieldInfoPtr_ScaleTime)) = value;
			}
		}

		// Token: 0x17002ADD RID: 10973
		// (get) Token: 0x06008D52 RID: 36178 RVA: 0x002520D8 File Offset: 0x002502D8
		// (set) Token: 0x06008D53 RID: 36179 RVA: 0x00043606 File Offset: 0x00041806
		public unsafe Coroutine scaleCoroutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.NativeFieldInfoPtr_scaleCoroutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.NativeFieldInfoPtr_scaleCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ADE RID: 10974
		// (get) Token: 0x06008D54 RID: 36180 RVA: 0x00252108 File Offset: 0x00250308
		// (set) Token: 0x06008D55 RID: 36181 RVA: 0x00043625 File Offset: 0x00041825
		public unsafe Button button
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.NativeFieldInfoPtr_button);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005FD5 RID: 24533
		private static readonly System.IntPtr NativeFieldInfoPtr_ScaleTarget;

		// Token: 0x04005FD6 RID: 24534
		private static readonly System.IntPtr NativeFieldInfoPtr_HoverScale;

		// Token: 0x04005FD7 RID: 24535
		private static readonly System.IntPtr NativeFieldInfoPtr_ScaleTime;

		// Token: 0x04005FD8 RID: 24536
		private static readonly System.IntPtr NativeFieldInfoPtr_scaleCoroutine;

		// Token: 0x04005FD9 RID: 24537
		private static readonly System.IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04005FDA RID: 24538
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005FDB RID: 24539
		private static readonly System.IntPtr NativeMethodInfoPtr_Hovered_Private_Void_0;

		// Token: 0x04005FDC RID: 24540
		private static readonly System.IntPtr NativeMethodInfoPtr_HoverEnd_Private_Void_0;

		// Token: 0x04005FDD RID: 24541
		private static readonly System.IntPtr NativeMethodInfoPtr_SetScale_Private_Void_Single_0;

		// Token: 0x04005FDE RID: 24542
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005FDF RID: 24543
		private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__5_0_Private_Void_BaseEventData_0;

		// Token: 0x04005FE0 RID: 24544
		private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__5_1_Private_Void_BaseEventData_0;

		// Token: 0x02000B63 RID: 2915
		[ObfuscatedName("ScheduleOne.UI.ButtonScaler+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DBED RID: 56301 RVA: 0x003478EC File Offset: 0x00345AEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ButtonScaler>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0>.NativeClassPtr);
				ButtonScaler.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				ButtonScaler.__c__DisplayClass8_0.NativeFieldInfoPtr_endScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0>.NativeClassPtr, "endScale");
				ButtonScaler.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0>.NativeClassPtr, 100680948);
				ButtonScaler.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0>.NativeClassPtr, 100680949);
			}

			// Token: 0x0600DBEE RID: 56302 RVA: 0x00347968 File Offset: 0x00345B68
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DBEF RID: 56303 RVA: 0x003479A4 File Offset: 0x00345BA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258749, XrefRangeEnd = 258754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DBF0 RID: 56304 RVA: 0x0006AB4F File Offset: 0x00068D4F
			public __c__DisplayClass8_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043D3 RID: 17363
			// (get) Token: 0x0600DBF1 RID: 56305 RVA: 0x003479E4 File Offset: 0x00345BE4
			// (set) Token: 0x0600DBF2 RID: 56306 RVA: 0x0006AB58 File Offset: 0x00068D58
			public unsafe ButtonScaler __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ButtonScaler>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043D4 RID: 17364
			// (get) Token: 0x0600DBF3 RID: 56307 RVA: 0x00347A14 File Offset: 0x00345C14
			// (set) Token: 0x0600DBF4 RID: 56308 RVA: 0x0006AB77 File Offset: 0x00068D77
			public unsafe float endScale
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.NativeFieldInfoPtr_endScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.NativeFieldInfoPtr_endScale)) = value;
				}
			}

			// Token: 0x040093FB RID: 37883
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040093FC RID: 37884
			private static readonly System.IntPtr NativeFieldInfoPtr_endScale;

			// Token: 0x040093FD RID: 37885
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093FE RID: 37886
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CCA RID: 3274
			[ObfuscatedName("ScheduleOne.UI.ButtonScaler+<>c__DisplayClass8_0+<<SetScale>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EAA5 RID: 60069 RVA: 0x00371E04 File Offset: 0x00370004
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique()
				{
					Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0>.NativeClassPtr, "<<SetScale>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr);
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>1__state");
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>2__current");
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>4__this");
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startScale_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<startScale>5__2");
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__lerpTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<lerpTime>5__3");
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<i>5__4");
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680950);
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680951);
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680952);
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680953);
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680954);
					ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680955);
				}

				// Token: 0x0600EAA6 RID: 60070 RVA: 0x00371F20 File Offset: 0x00370120
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EAA7 RID: 60071 RVA: 0x00371F68 File Offset: 0x00370168
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EAA8 RID: 60072 RVA: 0x00371F9C File Offset: 0x0037019C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258734, XrefRangeEnd = 258744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x1700489F RID: 18591
				// (get) Token: 0x0600EAA9 RID: 60073 RVA: 0x00371FD8 File Offset: 0x003701D8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EAAA RID: 60074 RVA: 0x00372018 File Offset: 0x00370218
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258744, XrefRangeEnd = 258749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170048A0 RID: 18592
				// (get) Token: 0x0600EAAB RID: 60075 RVA: 0x0037204C File Offset: 0x0037024C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EAAC RID: 60076 RVA: 0x000721C8 File Offset: 0x000703C8
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004899 RID: 18585
				// (get) Token: 0x0600EAAD RID: 60077 RVA: 0x0037208C File Offset: 0x0037028C
				// (set) Token: 0x0600EAAE RID: 60078 RVA: 0x000721D1 File Offset: 0x000703D1
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700489A RID: 18586
				// (get) Token: 0x0600EAAF RID: 60079 RVA: 0x003720B4 File Offset: 0x003702B4
				// (set) Token: 0x0600EAB0 RID: 60080 RVA: 0x000721EC File Offset: 0x000703EC
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700489B RID: 18587
				// (get) Token: 0x0600EAB1 RID: 60081 RVA: 0x003720E4 File Offset: 0x003702E4
				// (set) Token: 0x0600EAB2 RID: 60082 RVA: 0x0007220B File Offset: 0x0007040B
				public unsafe ButtonScaler.__c__DisplayClass8_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ButtonScaler.__c__DisplayClass8_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700489C RID: 18588
				// (get) Token: 0x0600EAB3 RID: 60083 RVA: 0x00372114 File Offset: 0x00370314
				// (set) Token: 0x0600EAB4 RID: 60084 RVA: 0x0007222A File Offset: 0x0007042A
				public unsafe float _startScale_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startScale_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startScale_5__2)) = value;
					}
				}

				// Token: 0x1700489D RID: 18589
				// (get) Token: 0x0600EAB5 RID: 60085 RVA: 0x0037213C File Offset: 0x0037033C
				// (set) Token: 0x0600EAB6 RID: 60086 RVA: 0x00072245 File Offset: 0x00070445
				public unsafe float _lerpTime_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__lerpTime_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__lerpTime_5__3)) = value;
					}
				}

				// Token: 0x1700489E RID: 18590
				// (get) Token: 0x0600EAB7 RID: 60087 RVA: 0x00372164 File Offset: 0x00370364
				// (set) Token: 0x0600EAB8 RID: 60088 RVA: 0x00072260 File Offset: 0x00070460
				public unsafe float _i_5__4
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonScaler.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x04009CF8 RID: 40184
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009CF9 RID: 40185
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009CFA RID: 40186
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009CFB RID: 40187
				private static readonly System.IntPtr NativeFieldInfoPtr__startScale_5__2;

				// Token: 0x04009CFC RID: 40188
				private static readonly System.IntPtr NativeFieldInfoPtr__lerpTime_5__3;

				// Token: 0x04009CFD RID: 40189
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x04009CFE RID: 40190
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009CFF RID: 40191
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D00 RID: 40192
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009D01 RID: 40193
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009D02 RID: 40194
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D03 RID: 40195
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
