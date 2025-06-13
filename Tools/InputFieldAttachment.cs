using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200054C RID: 1356
	public class InputFieldAttachment : MonoBehaviour
	{
		// Token: 0x0600783C RID: 30780 RVA: 0x0020D358 File Offset: 0x0020B558
		// Note: this type is marked as 'beforefieldinit'.
		static InputFieldAttachment()
		{
			Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "InputFieldAttachment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr);
			InputFieldAttachment.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr, 100678538);
			InputFieldAttachment.NativeMethodInfoPtr_EditStart_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr, 100678539);
			InputFieldAttachment.NativeMethodInfoPtr_EndEdit_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr, 100678540);
			InputFieldAttachment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr, 100678541);
		}

		// Token: 0x0600783D RID: 30781 RVA: 0x0020D3D8 File Offset: 0x0020B5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234376, XrefRangeEnd = 234440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600783E RID: 30782 RVA: 0x0020D40C File Offset: 0x0020B60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234440, XrefRangeEnd = 234444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EditStart(string newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newVal);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.NativeMethodInfoPtr_EditStart_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600783F RID: 30783 RVA: 0x0020D450 File Offset: 0x0020B650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234444, XrefRangeEnd = 234448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndEdit(string newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newVal);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.NativeMethodInfoPtr_EndEdit_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007840 RID: 30784 RVA: 0x0020D494 File Offset: 0x0020B694
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputFieldAttachment() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007841 RID: 30785 RVA: 0x00038BB8 File Offset: 0x00036DB8
		public InputFieldAttachment(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400522C RID: 21036
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400522D RID: 21037
		private static readonly System.IntPtr NativeMethodInfoPtr_EditStart_Private_Void_String_0;

		// Token: 0x0400522E RID: 21038
		private static readonly System.IntPtr NativeMethodInfoPtr_EndEdit_Private_Void_String_0;

		// Token: 0x0400522F RID: 21039
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AE4 RID: 2788
		[ObfuscatedName("ScheduleOne.Tools.InputFieldAttachment+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D7DE RID: 55262 RVA: 0x0033C094 File Offset: 0x0033A294
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass0_0>.NativeClassPtr);
				InputFieldAttachment.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass0_0>.NativeClassPtr, "<>4__this");
				InputFieldAttachment.__c__DisplayClass0_0.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass0_0>.NativeClassPtr, "inputField");
				InputFieldAttachment.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass0_0>.NativeClassPtr, 100678542);
				InputFieldAttachment.__c__DisplayClass0_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass0_0>.NativeClassPtr, 100678543);
			}

			// Token: 0x0600D7DF RID: 55263 RVA: 0x0033C110 File Offset: 0x0033A310
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass0_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D7E0 RID: 55264 RVA: 0x0033C14C File Offset: 0x0033A34C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234372, XrefRangeEnd = 234376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.__c__DisplayClass0_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D7E1 RID: 55265 RVA: 0x00068C24 File Offset: 0x00066E24
			public __c__DisplayClass0_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042A8 RID: 17064
			// (get) Token: 0x0600D7E2 RID: 55266 RVA: 0x0033C190 File Offset: 0x0033A390
			// (set) Token: 0x0600D7E3 RID: 55267 RVA: 0x00068C2D File Offset: 0x00066E2D
			public unsafe InputFieldAttachment __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldAttachment.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputFieldAttachment>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldAttachment.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042A9 RID: 17065
			// (get) Token: 0x0600D7E4 RID: 55268 RVA: 0x0033C1C0 File Offset: 0x0033A3C0
			// (set) Token: 0x0600D7E5 RID: 55269 RVA: 0x00068C4C File Offset: 0x00066E4C
			public unsafe InputField inputField
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldAttachment.__c__DisplayClass0_0.NativeFieldInfoPtr_inputField);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldAttachment.__c__DisplayClass0_0.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009193 RID: 37267
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009194 RID: 37268
			private static readonly System.IntPtr NativeFieldInfoPtr_inputField;

			// Token: 0x04009195 RID: 37269
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009196 RID: 37270
			private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_BaseEventData_0;
		}
	}
}
