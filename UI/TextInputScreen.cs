using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000692 RID: 1682
	public class TextInputScreen : Singleton<TextInputScreen>
	{
		// Token: 0x06009529 RID: 38185 RVA: 0x00269478 File Offset: 0x00267678
		// Note: this type is marked as 'beforefieldinit'.
		static TextInputScreen()
		{
			Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "TextInputScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr);
			TextInputScreen.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, "Canvas");
			TextInputScreen.NativeFieldInfoPtr_HeaderLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, "HeaderLabel");
			TextInputScreen.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, "InputField");
			TextInputScreen.NativeFieldInfoPtr_onSubmit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, "onSubmit");
			TextInputScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681895);
			TextInputScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681896);
			TextInputScreen.NativeMethodInfoPtr_Submit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681897);
			TextInputScreen.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681898);
			TextInputScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681899);
			TextInputScreen.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681900);
			TextInputScreen.NativeMethodInfoPtr_Open_Public_Void_String_String_OnSubmit_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681901);
			TextInputScreen.NativeMethodInfoPtr_Close_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681902);
			TextInputScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681903);
		}

		// Token: 0x17002D85 RID: 11653
		// (get) Token: 0x0600952A RID: 38186 RVA: 0x002695AC File Offset: 0x002677AC
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 263602, RefRangeEnd = 263603, XrefRangeStart = 263602, XrefRangeEnd = 263603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600952B RID: 38187 RVA: 0x002695E8 File Offset: 0x002677E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268872, XrefRangeEnd = 268885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInputScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600952C RID: 38188 RVA: 0x00269624 File Offset: 0x00267824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268885, XrefRangeEnd = 268886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Submit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr_Submit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600952D RID: 38189 RVA: 0x00269658 File Offset: 0x00267858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268886, XrefRangeEnd = 268887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600952E RID: 38190 RVA: 0x0026968C File Offset: 0x0026788C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268887, XrefRangeEnd = 268890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600952F RID: 38191 RVA: 0x002696C0 File Offset: 0x002678C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268890, XrefRangeEnd = 268893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009530 RID: 38192 RVA: 0x00269704 File Offset: 0x00267904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 268922, RefRangeEnd = 268923, XrefRangeStart = 268893, XrefRangeEnd = 268922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string header, string text, TextInputScreen.OnSubmit _onSubmit, int maxChars = 10000)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(header);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_onSubmit);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref maxChars;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr_Open_Public_Void_String_String_OnSubmit_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009531 RID: 38193 RVA: 0x00269778 File Offset: 0x00267978
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 268948, RefRangeEnd = 268952, XrefRangeStart = 268923, XrefRangeEnd = 268948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool submit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref submit;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr_Close_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009532 RID: 38194 RVA: 0x002697B8 File Offset: 0x002679B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268952, XrefRangeEnd = 268955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextInputScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009533 RID: 38195 RVA: 0x00047F30 File Offset: 0x00046130
		public TextInputScreen(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D81 RID: 11649
		// (get) Token: 0x06009534 RID: 38196 RVA: 0x002697F4 File Offset: 0x002679F4
		// (set) Token: 0x06009535 RID: 38197 RVA: 0x00047F39 File Offset: 0x00046139
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D82 RID: 11650
		// (get) Token: 0x06009536 RID: 38198 RVA: 0x00269824 File Offset: 0x00267A24
		// (set) Token: 0x06009537 RID: 38199 RVA: 0x00047F58 File Offset: 0x00046158
		public unsafe TextMeshProUGUI HeaderLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_HeaderLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_HeaderLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D83 RID: 11651
		// (get) Token: 0x06009538 RID: 38200 RVA: 0x00269854 File Offset: 0x00267A54
		// (set) Token: 0x06009539 RID: 38201 RVA: 0x00047F77 File Offset: 0x00046177
		public unsafe TMP_InputField InputField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_InputField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D84 RID: 11652
		// (get) Token: 0x0600953A RID: 38202 RVA: 0x00269884 File Offset: 0x00267A84
		// (set) Token: 0x0600953B RID: 38203 RVA: 0x00047F96 File Offset: 0x00046196
		public unsafe TextInputScreen.OnSubmit onSubmit
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_onSubmit);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextInputScreen.OnSubmit>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_onSubmit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040064C4 RID: 25796
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040064C5 RID: 25797
		private static readonly System.IntPtr NativeFieldInfoPtr_HeaderLabel;

		// Token: 0x040064C6 RID: 25798
		private static readonly System.IntPtr NativeFieldInfoPtr_InputField;

		// Token: 0x040064C7 RID: 25799
		private static readonly System.IntPtr NativeFieldInfoPtr_onSubmit;

		// Token: 0x040064C8 RID: 25800
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040064C9 RID: 25801
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040064CA RID: 25802
		private static readonly System.IntPtr NativeMethodInfoPtr_Submit_Public_Void_0;

		// Token: 0x040064CB RID: 25803
		private static readonly System.IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		// Token: 0x040064CC RID: 25804
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040064CD RID: 25805
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x040064CE RID: 25806
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_String_String_OnSubmit_Int32_0;

		// Token: 0x040064CF RID: 25807
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Private_Void_Boolean_0;

		// Token: 0x040064D0 RID: 25808
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BA0 RID: 2976
		public sealed class OnSubmit : Il2CppSystem.MulticastDelegate
		{
			// Token: 0x0600DEDA RID: 57050 RVA: 0x0034FFA4 File Offset: 0x0034E1A4
			// Note: this type is marked as 'beforefieldinit'.
			static OnSubmit()
			{
				Il2CppClassPointerStore<TextInputScreen.OnSubmit>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, "OnSubmit");
				TextInputScreen.OnSubmit.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen.OnSubmit>.NativeClassPtr, 100681904);
				TextInputScreen.OnSubmit.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen.OnSubmit>.NativeClassPtr, 100681905);
				TextInputScreen.OnSubmit.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen.OnSubmit>.NativeClassPtr, 100681906);
				TextInputScreen.OnSubmit.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen.OnSubmit>.NativeClassPtr, 100681907);
			}

			// Token: 0x0600DEDB RID: 57051 RVA: 0x00350018 File Offset: 0x0034E218
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 86967, RefRangeEnd = 86971, XrefRangeStart = 86967, XrefRangeEnd = 86971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnSubmit(Il2CppSystem.Object @object, System.IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextInputScreen.OnSubmit>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref method;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.OnSubmit.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DEDC RID: 57052 RVA: 0x00350074 File Offset: 0x0034E274
			[CallerCount(0)]
			public unsafe void Invoke(string text)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.OnSubmit.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DEDD RID: 57053 RVA: 0x003500B8 File Offset: 0x0034E2B8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 77936, RefRangeEnd = 77937, XrefRangeStart = 77936, XrefRangeEnd = 77937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppSystem.IAsyncResult BeginInvoke(string text, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.OnSubmit.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
			}

			// Token: 0x0600DEDE RID: 57054 RVA: 0x0035012C File Offset: 0x0034E32C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.OnSubmit.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DEDF RID: 57055 RVA: 0x0006C380 File Offset: 0x0006A580
			public OnSubmit(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600DEE0 RID: 57056 RVA: 0x0006C389 File Offset: 0x0006A589
			public static implicit operator TextInputScreen.OnSubmit(System.Action<string> A_0)
			{
				return DelegateSupport.ConvertDelegate<TextInputScreen.OnSubmit>(A_0);
			}

			// Token: 0x0600DEE1 RID: 57057 RVA: 0x0006C391 File Offset: 0x0006A591
			public static TextInputScreen.OnSubmit operator +(TextInputScreen.OnSubmit A_0, TextInputScreen.OnSubmit A_1)
			{
				return Il2CppSystem.Delegate.Combine(A_0, A_1).Cast<TextInputScreen.OnSubmit>();
			}

			// Token: 0x0600DEE2 RID: 57058 RVA: 0x0006C39F File Offset: 0x0006A59F
			public static TextInputScreen.OnSubmit operator -(TextInputScreen.OnSubmit A_0, TextInputScreen.OnSubmit A_1)
			{
				Il2CppSystem.Delegate result;
				Il2CppSystem.Delegate @delegate = result = Il2CppSystem.Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<TextInputScreen.OnSubmit>();
				}
				return result;
			}

			// Token: 0x040095C0 RID: 38336
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040095C1 RID: 38337
			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;

			// Token: 0x040095C2 RID: 38338
			private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0;

			// Token: 0x040095C3 RID: 38339
			private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
